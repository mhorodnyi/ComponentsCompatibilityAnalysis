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
using HDDModel = ComputerComponents.Models.HDD;
using HDDView = CumputerComponentsUI.Views.Components.HDD;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for HDDList.xaml
    /// </summary>
    public partial class HDDList : Window
    {
        public HDDList()
        {
            InitializeComponent();

            HDDs = ComponentsCollections.HDDs;

            int i = 0;
            foreach (HDDModel hdd in HDDs)
            {
                HDDView HDDView = new HDDView
                {
                    DataContext = hdd,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                HDDGrid.Children.Add(HDDView);
                HDDView.ComponentData.DataContext = hdd;
                HDDView.MouseDoubleClick += getHDD;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                HDDGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(HDDView, i);
                Grid.SetColumn(HDDView, 0);

                i++;
            }
        }

        private List<HDDModel> HDDs;

        private void getHDD(object sender, MouseButtonEventArgs e)
        {
            Assembly.HDD = (HDDModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
