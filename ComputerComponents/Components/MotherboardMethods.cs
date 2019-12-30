using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class Motherboard : IComponent, IWritable
    {
        public Motherboard()
        {
            this.Chipset = "";
            this.Coast = 0;
            this.Name = "";
            this.Socket = "";
            this.Vendor = "";
        }
         public Motherboard(string vendor, string name, string chipset, string socket, decimal coast)
        {
            this.Chipset = chipset;
            this.Coast = coast;
            this.Name = name;
            this.Socket = socket;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.Motherboards.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Chipset + " " + this.Socket;
        }
    }
}
