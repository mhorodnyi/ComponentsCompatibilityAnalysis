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
            foreach (SSDModel cpu in SSDs)
            {
                SSDView CPUView = new SSDView
                {
                    DataContext = cpu,
                    Height = 120,
                    Width = 400
                };

                SSDGrid.Children.Add(CPUView);
                CPUView.ComponentData.DataContext = cpu;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                SSDGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(CPUView, i);
                Grid.SetColumn(CPUView, 0);

                i++;
            }
        }

        private List<SSDModel> SSDs;
    }
}
