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
using MotherboardModel = ComputerComponents.Models.Motherboard;
using MotherboardView = CumputerComponentsUI.Views.Components.Motherboard;


namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for MotherboardsList.xaml
    /// </summary>
    public partial class MotherboardsList : Window
    {
        public MotherboardsList()
        {
            InitializeComponent();

            Motherboards = ComponentsCollections.Motherboards;

            int i = 0;
            foreach (MotherboardModel motherboard in Motherboards)
            {
                MotherboardView motherboardView = new MotherboardView
                {
                    DataContext = motherboard,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                MotherboardGrid.Children.Add(motherboardView);
                motherboardView.ComponentData.DataContext = motherboard;
                motherboardView.MouseDoubleClick += getMotherboard;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                MotherboardGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(motherboardView, i);
                Grid.SetColumn(motherboardView, 0);

                i++;
            }
        }

        public List<MotherboardModel> Motherboards = new List<MotherboardModel>();

        private void getMotherboard(object sender, MouseButtonEventArgs e)
        {
            Assembly.Motherboard = (MotherboardModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
