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

        public bool IsAssemblyCompatibility()
        {
            bool Compatibility = true;
            if (Motherboard != null &&
                Processor != null &&
                Memory != null &&
                PowerSupply != null)
            {
                if (GraphicalCard != null)
                {
                    Compatibility = Compatibility && GraphicalCard.MinPowerRequires <= PowerSupply.Power;
                } else
                {
                    Compatibility = Compatibility && Processor.GraphicalCore.Replace(" ", "") == "+";
                }
                Compatibility = Compatibility && Motherboard.Socket == Processor.Socket;
                Compatibility = Compatibility && (Fan != null ? Fan.Sockets.IndexOf(Processor.Socket.Replace(" ", "")) >= 0 : true);
            }
            return Compatibility;
        }
    }
}
