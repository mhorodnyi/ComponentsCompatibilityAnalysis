using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class PowerSupply : IComponent, IWritable
    {
        public PowerSupply()
        {
            this.Coast = 0;
            this.Name = "";
            this.Power = 0;
            this.Vendor = "";
        }
        public PowerSupply(string vendor, string name, int power, decimal coast)
        {
            this.Coast = coast;
            this.Name = name;
            this.Power = power;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.PowerSupplies.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Power + "W";
        }
    }
}
