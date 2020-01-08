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
        public static Processor CPU { get; set; }
        public static Memory Memory { get; set; }
        public static GraphicalCard GPU { get; set; }
        public static PowerSupply PowerSupply { get; set; }
        public static Fan Fan { get; set; }
        public static HDD HDD { get; set; }
        public static SSD SSD { get; set; }

        public static string AssemblyCompatibilityMessage()
        {
            string message = ProjectResources.ItsFineAssembly;

            if (GPU != null && PowerSupply != null)
            {
                message = GPU.MinPowerRequires <= PowerSupply.Power ?
                    message : ProjectResources.NotEnoughPowerOfPS;
            }
            if (CPU != null && GPU == null)
            {
                message = CPU.GraphicalCore.Replace(" ", "") == "+" ?
                    message : ProjectResources.ThereAreNotGraphicalCores;
            }
            if (Motherboard != null && CPU != null)
            {
                message = Motherboard.Socket == CPU.Socket ?
                    message : ProjectResources.CPUAndMotherboardProblems;
            }
            if (Fan != null && CPU != null)
            {
                message = (Fan.Sockets.IndexOf(CPU.Socket.Replace(" ", "")) >= 0) ?
                    message : ProjectResources.FansSocketNotCompatibility;
                message = CPU.TDP <= Fan.TDP ?
                    message : ProjectResources.FansTDPSmallerThenCPUs;
            }
            return message;
        }
    }
}
