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
using CPUModel = ComputerComponents.Models.Processor;
using CPUView = CumputerComponentsUI.Views.Components.CPU;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for CPUList.xaml
    /// </summary>
    public partial class CPUList : Window
    {
        public CPUList()
        {
            InitializeComponent();

            CPUs = ComponentsCollections.CPUs;

            int i = 0;
            foreach (CPUModel cpu in CPUs)
            {
                CPUView CPUView = new CPUView
                {
                    DataContext = cpu,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                CPUGrid.Children.Add(CPUView);
                CPUView.ComponentData.DataContext = cpu;
                CPUView.MouseDoubleClick += getCPU;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                CPUGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(CPUView, i);
                Grid.SetColumn(CPUView, 0);

                i++;
            }
        }

        private List<CPUModel> CPUs;

        private void getCPU(object sender, MouseButtonEventArgs e)
        {
            Assembly.CPU = (CPUModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
