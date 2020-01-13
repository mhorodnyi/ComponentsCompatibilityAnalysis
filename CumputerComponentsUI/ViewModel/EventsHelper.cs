using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ComputerComponents.Interfaces;
using ModelsComponents = ComputerComponents.Models;
using ViewComponents = CumputerComponentsUI.Views.Components;
using ComponentWindow = CumputerComponentsUI.Views.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CumputerComponentsUI.ViewModel
{
    static class EventsHelper
    {
        private static IComponent LastComponent;
        private static Window LastWindow;

        public static void GetWindow(object uc)
        {
            LastWindow.Show();
            LastWindow.Closed += (object sender, EventArgs e) =>
            {
                GetDataContext(uc);
                ((UserControl)uc).DataContext = EventsHelper.LastComponent;
            };
        }
        public static void GetDataContext(object obj)
        {
            if (obj is ViewComponents.Motherboard)
            {
                LastComponent = Assembly.Motherboard;
                LastWindow = new ComponentWindow.MotherboardsList();
            }
            else if (obj is ViewComponents.CPU)
            {
                LastComponent = Assembly.CPU;
                LastWindow = new ComponentWindow.CPUList();
            }
            else if (obj is ViewComponents.GPU)
            {
                LastComponent = Assembly.GPU;
                LastWindow = new ComponentWindow.GPUList();
            }
            else if (obj is ViewComponents.Memory)
            {
                LastComponent = Assembly.Memory;
                LastWindow = new ComponentWindow.MemoryList();
            }
            else if (obj is ViewComponents.PowerSupply)
            {
                LastComponent = Assembly.PowerSupply;
                LastWindow = new ComponentWindow.PowerSupplyList();
            }
            else if (obj is ViewComponents.Fan)
            {
                LastComponent = Assembly.Fan;
                LastWindow = new ComponentWindow.FanList();
            }
            else if (obj is ViewComponents.HDD)
            {
                LastComponent = Assembly.HDD;
                LastWindow = new ComponentWindow.HDDList();
            }
            else if (obj is ViewComponents.SSD)
            {
                LastComponent = Assembly.SSD;
                LastWindow = new ComponentWindow.SSDList();
            }
        }
    }
}
