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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ComputerComponents.Models;
using CumputerComponentsUI.ViewModel;
using CumputerComponentsUI.Views.Windows;
using MotherboardModel = ComputerComponents.Models.Motherboard;

namespace CumputerComponentsUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MotherboardView.DataContext = Assembly.Motherboard;
        }

        private void MotherboardView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MotherboardsList motherboards = new MotherboardsList();
            motherboards.Show();
        }

        private void CPUView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CPUList cpus = new CPUList();
            cpus.Show();
        }

        private void GPUView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GPUList gpus = new GPUList();
            gpus.Show();
        }

        private void MemoryView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MemoryList memories = new MemoryList();
            memories.Show();
        }

        private void PowerSupplyView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PowerSupplyList PSs = new PowerSupplyList();
            PSs.Show();
        }

        private void FanView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FanList fans = new FanList();
            fans.Show();
        }

        private void HDDView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HDDList hdds = new HDDList();
            hdds.Show();
        }

        private void SSDView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SSDList ssds = new SSDList();
            ssds.Show();
        }
    }
}
