using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class GraphicalCard : IComponent, IWritable
    {
        public GraphicalCard()
        {
            this.Chipset = "";
            this.Coast = 0;
            this.MinPowerRequires = 0;
            this.Name = "";
            this.Vendor = "";
        }
        public GraphicalCard(string vendor, string name, string chipset, int minPower, decimal coast)
        {
            this.Chipset = chipset;
            this.Coast = coast;
            this.MinPowerRequires = minPower;
            this.Name = name;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.GraphicalCards.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Chipset;
        }
    }
}
