using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CumputerComponentsUI.ViewModel;
using FanModel = ComputerComponents.Models.Fan;
using FanView = CumputerComponentsUI.Views.Components.Fan;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for FanList.xaml
    /// </summary>
    public partial class FanList : Window
    {
        public FanList()
        {
            InitializeComponent();

            Fans = ComponentsCollections.Fans;

            int i = 0;
            foreach (FanModel cpu in Fans)
            {
                FanView FanView = new FanView
                {
                    DataContext = cpu,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                FanGrid.Children.Add(FanView);
                FanView.ComponentData.DataContext = cpu;
                FanView.MouseDoubleClick += getFan;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                FanGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(FanView, i);
                Grid.SetColumn(FanView, 0);

                i++;
            }
        }

        private List<FanModel> Fans;

        private void getFan(object sender, MouseButtonEventArgs e)
        {
            Assembly.Fan = (FanModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
