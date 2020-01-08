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
        }

        private void MotherboardView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MotherboardsList motherboards = new MotherboardsList();
            motherboards.Show();
            motherboards.Closed += (object sender1, EventArgs ev) =>
            {
                MotherboardView.DataContext = Assembly.Motherboard;
            };
        }

        private void CPUView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CPUList cpus = new CPUList();
            cpus.Show();
            cpus.Closed += (object sender1, EventArgs ev) =>
            {
                CPUView.DataContext = Assembly.CPU;
            };
        }

        private void GPUView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GPUList gpus = new GPUList();
            gpus.Show();
            gpus.Closed += (object sender1, EventArgs ev) =>
            {
                GPUView.DataContext = Assembly.GPU;
            };
        }

        private void MemoryView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MemoryList memories = new MemoryList();
            memories.Show();
            memories.Closed += (object sender1, EventArgs ev) =>
            {
                MemoryView.DataContext = Assembly.Memory;
            };
        }

        private void PowerSupplyView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PowerSupplyList PSs = new PowerSupplyList();
            PSs.Show();
            PSs.Closed += (object sender1, EventArgs ev) =>
            {
                PowerSupplyView.DataContext = Assembly.PowerSupply;
            };
        }

        private void FanView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FanList fans = new FanList();
            fans.Show();
            fans.Closed += (object sender1, EventArgs ev) =>
            {
                FanView.DataContext = Assembly.Fan;
            };
        }

        private void HDDView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HDDList hdds = new HDDList();
            hdds.Show();
            hdds.Closed += (object sender1, EventArgs ev) =>
            {
                HDDView.DataContext = Assembly.HDD;
            };
        }

        private void SSDView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SSDList ssds = new SSDList();
            ssds.Show();
            ssds.Closed += (object sender1, EventArgs ev) =>
            {
                SSDView.DataContext = Assembly.SSD;
            };
        }
    }
}
