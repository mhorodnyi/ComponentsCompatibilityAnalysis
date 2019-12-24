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
using ComputerComponents.Interfaces;
using ComputerComponents.Analyzer;

namespace CumputerComponentsUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Assembly assembly;

        public MainWindow()
        {
            InitializeComponent();
            assembly = new Assembly();

            using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
            {
                MotherboardsList.ItemsSource = entities.Motherboards.ToList();
                CPUsList.ItemsSource = entities.Processors.ToList();
                MemoriesList.ItemsSource = entities.Memories.ToList();
                GPUsList.ItemsSource = entities.GraphicalCards.ToList();
                PowerSuppliesList.ItemsSource = entities.PowerSupplies.ToList();
                FansList.ItemsSource = entities.Fans.ToList();
                HDDsList.ItemsSource = entities.HDDs.ToList();
                SSDsList.ItemsSource = entities.SSDs.ToList();
            }
        }

        private void MotherboardsList_DropDownClosed(object sender, EventArgs e)
        {
            if (MotherboardsList.SelectedItem is Motherboard)
            {
                assembly.Motherboard = (Motherboard)MotherboardsList.SelectedItem;
                CheckAssembly();
            }
        }

        private void CPUsList_DropDownClosed(object sender, EventArgs e)
        {
            if (CPUsList.SelectedItem is Processor)
            {
                assembly.Processor = (Processor)CPUsList.SelectedItem;
                CheckAssembly();
            }
        }

        private void MemoriesList_DropDownClosed(object sender, EventArgs e)
        {
            if (MemoriesList.SelectedItem is Memory)
            {
                assembly.Memory = (Memory)MemoriesList.SelectedItem;
                CheckAssembly();
            }
        }

        private void GPUsList_DropDownClosed(object sender, EventArgs e)
        {
            if (GPUsList.SelectedItem is GraphicalCard)
            {
                assembly.GraphicalCard = (GraphicalCard)GPUsList.SelectedItem;
                CheckAssembly();
            }
        }

        private void PowerSuppliesList_DropDownClosed(object sender, EventArgs e)
        {
            if (PowerSuppliesList.SelectedItem is PowerSupply)
            {
                assembly.PowerSupply = (PowerSupply)PowerSuppliesList.SelectedItem;
                CheckAssembly();
            }
        }

        private void FansList_DropDownClosed(object sender, EventArgs e)
        {
            if (FansList.SelectedItem is Fan)
            {
                assembly.Fan = (Fan)FansList.SelectedItem;
                CheckAssembly();
            }
        }

        private void HDDsList_DropDownClosed(object sender, EventArgs e)
        {
            if (HDDsList.SelectedItem is HDD)
            {
                assembly.HDD = (HDD)HDDsList.SelectedItem;
                CheckAssembly();
            }
        }

        private void SSDsList_DropDownClosed(object sender, EventArgs e)
        {
            if (SSDsList.SelectedItem is SSD)
            {
                assembly.SSD = (SSD)SSDsList.SelectedItem;
                CheckAssembly();
            }
        }

        private void CheckAssembly()
        {
             Label.Content = assembly.IsAssemblyCompatibility() ? "It is fine compatibility" : "It is bad compatibility";
        }
    }
}
