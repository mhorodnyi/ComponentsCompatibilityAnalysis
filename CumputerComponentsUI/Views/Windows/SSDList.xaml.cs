using CumputerComponentsUI.ViewModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using SSDModel = ComputerComponents.Models.SSD;
using SSDView = CumputerComponentsUI.Views.Components.SSD;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for SSDList.xaml
    /// </summary>
    public partial class SSDList : Window
    {
        public SSDList()
        {
            InitializeComponent();

            SSDs = ComponentsCollections.SSDs;

            int i = 0;
            foreach (SSDModel ssd in SSDs)
            {
                SSDView SSDView = new SSDView
                {
                    DataContext = ssd,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                SSDGrid.Children.Add(SSDView);
                SSDView.ComponentData.DataContext = ssd;
                SSDView.MouseDoubleClick += getSSD;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                SSDGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(SSDView, i);
                Grid.SetColumn(SSDView, 0);

                i++;
            }
        }

        private List<SSDModel> SSDs;

        private void getSSD(object sender, MouseButtonEventArgs e)
        {
            Assembly.SSD = (SSDModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
