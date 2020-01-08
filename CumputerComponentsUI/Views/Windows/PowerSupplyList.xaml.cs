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
using PowerSupplyModel = ComputerComponents.Models.PowerSupply;
using PowerSupplyView = CumputerComponentsUI.Views.Components.PowerSupply;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for PowerSupplyList.xaml
    /// </summary>
    public partial class PowerSupplyList : Window
    {
        public PowerSupplyList()
        {
            InitializeComponent();

            PowerSupplies = ComponentsCollections.PowerSupplies;

            int i = 0;
            foreach (PowerSupplyModel ps in PowerSupplies)
            {
                PowerSupplyView PowerSupplyView = new PowerSupplyView
                {
                    DataContext = ps,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                PowerSupplyGrid.Children.Add(PowerSupplyView);
                PowerSupplyView.ComponentData.DataContext = ps;
                PowerSupplyView.MouseDoubleClick += getPS;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                PowerSupplyGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(PowerSupplyView, i);
                Grid.SetColumn(PowerSupplyView, 0);

                i++;
            }
        }

        private List<PowerSupplyModel> PowerSupplies;

        private void getPS(object sender, MouseButtonEventArgs e)
        {
            Assembly.PowerSupply = (PowerSupplyModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
