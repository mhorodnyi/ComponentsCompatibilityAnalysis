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
using MemoryModel = ComputerComponents.Models.Memory;
using MemoryView = CumputerComponentsUI.Views.Components.Memory;

namespace CumputerComponentsUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for MemoryList.xaml
    /// </summary>
    public partial class MemoryList : Window
    {
        public MemoryList()
        {
            InitializeComponent();

            Memories = ComponentsCollections.Memories;

            int i = 0;
            foreach (MemoryModel memory in Memories)
            {
                MemoryView MemoryView = new MemoryView
                {
                    DataContext = memory,
                    Height = 120,
                    Width = 400,
                    Background = Brushes.LightYellow,
                    Margin = new Thickness(10, 10, 0, 0)
                };

                MemoryGrid.Children.Add(MemoryView);
                MemoryView.ComponentData.DataContext = memory;
                MemoryView.MouseDoubleClick += getMemory;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                MemoryGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(MemoryView, i);
                Grid.SetColumn(MemoryView, 0);

                i++;
            }
        }

        private List<MemoryModel> Memories;

        private void getMemory(object sender, MouseButtonEventArgs e)
        {
            Assembly.Memory = (MemoryModel)((UserControl)sender).DataContext;
            this.Close();
        }
    }
}
