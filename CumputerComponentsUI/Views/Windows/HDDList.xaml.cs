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
            foreach (HDDModel cpu in HDDs)
            {
                HDDView HDDView = new HDDView
                {
                    DataContext = cpu,
                    Height = 120,
                    Width = 400
                };

                HDDGrid.Children.Add(HDDView);
                HDDView.ComponentData.DataContext = cpu;

                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(120);
                HDDGrid.RowDefinitions.Add(newRow);

                Grid.SetRow(HDDView, i);
                Grid.SetColumn(HDDView, 0);

                i++;
            }
        }

        private List<HDDModel> HDDs;
    }
}
