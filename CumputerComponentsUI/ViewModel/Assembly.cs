using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Models;
using ComputerComponents.Interfaces;
using ProjectResources = CumputerComponentsUI.Properties.Resources;

namespace CumputerComponentsUI.ViewModel
{
    public static class Assembly
    {
        public static Motherboard Motherboard { get; set; }
        public static Processor Processor { get; set; }
        public static Memory Memory { get; set; }
        public static GraphicalCard GraphicalCard { get; set; }
        public static PowerSupply PowerSupply { get; set; }
        public static Fan Fan { get; set; }
        public static HDD HDD { get; set; }
        public static SSD SSD { get; set; }

        public static string AssemblyCompatibilityMessage()
        {
            string message = ProjectResources.ItsFineAssembly;

            if (GraphicalCard != null && PowerSupply != null)
            {
                message = GraphicalCard.MinPowerRequires <= PowerSupply.Power ?
                    message : ProjectResources.NotEnoughPowerOfPS;
            }
            if (Processor != null && GraphicalCard == null)
            {
                message = Processor.GraphicalCore.Replace(" ", "") == "+" ?
                    message : ProjectResources.ThereAreNotGraphicalCores;
            }
            if (Motherboard != null && Processor != null)
            {
                message = Motherboard.Socket == Processor.Socket ?
                    message : ProjectResources.CPUAndMotherboardProblems;
            }
            if (Fan != null && Processor != null)
            {
                message = (Fan.Sockets.IndexOf(Processor.Socket.Replace(" ", "")) >= 0) ?
                    message : ProjectResources.FansSocketNotCompatibility;
                message = Processor.TDP <= Fan.TDP ?
                    message : ProjectResources.FansTDPSmallerThenCPUs;
            }
            return message;
        }
    }
}
