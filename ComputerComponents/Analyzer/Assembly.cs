using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Models;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Analyzer
{
    public class Assembly
    {
        public Motherboard Motherboard { get; set; }
        public Processor Processor { get; set; }
        public Memory Memory { get; set; }
        public GraphicalCard GraphicalCard { get; set; }
        public PowerSupply PowerSupply { get; set; }
        public Fan Fan { get; set; }
        public HDD HDD { get; set; }
        public SSD SSD { get; set; }

        public string AssemblyCompatibilityMessage()
        {
            string message = Properties.Resources.ItsFineAssembly;

            if (GraphicalCard != null && PowerSupply != null)
            {
                message = GraphicalCard.MinPowerRequires <= PowerSupply.Power ?
                    message : Properties.Resources.NotEnoughPowerOfPS;
            }
            if (Processor != null && GraphicalCard == null)
            {
                message = Processor.GraphicalCore.Replace(" ", "") == "+" ?
                    message : Properties.Resources.ThereAreNotGraphicalCores;
            }
            if (Motherboard != null && Processor != null)
            {
                message = Motherboard.Socket == Processor.Socket ?
                    message : Properties.Resources.CPUAndMotherboardProblems;
            }
            if (Fan != null && Processor != null)
            {
                message = (Fan.Sockets.IndexOf(Processor.Socket.Replace(" ", "")) >= 0) ?
                    message : Properties.Resources.FansSocketNotCompatibility;
                message = Processor.TDP <= Fan.TDP ?
                    message : Properties.Resources.FansTDPSmallerThenCPUs;
            }
            return message;
        }
    }
}
