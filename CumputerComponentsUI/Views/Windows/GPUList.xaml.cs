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
using GPUModel = ComputerComponents.Models.GraphicalCard;
using GPUView = CumputerComponentsUI.Views.Components.GPU;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for GPUList.xaml
    /// </summary>
    public partial class GPUList : Window
    {
        public GPUList()
        {
            InitializeComponent();

            GPUs = ComponentsCollections.GPUs;

            int i = 0;
            foreach (GPUModel gpu in GPUs)
            {
                GPUView GPUView = new GPUView
                {
                    DataContext = gpu,
                    Height = 120,
                    Width = 400
                };

                GPUGrid.Children.Add(GPUView);
                GPUView.ComponentData.DataContext = gpu;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                GPUGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(GPUView, i);
                Grid.SetColumn(GPUView, 0);

                i++;
            }
        }

        private List<GPUModel> GPUs;
    }
}
