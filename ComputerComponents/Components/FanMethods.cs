using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class Fan : IComponent, IWritable
    {
        public Fan()
        {
            this.Coast = 0;
            this.Name = "";
            this.Sockets = "";
            this.TDP = 0;
            this.Vendor = "";
        }
        public Fan(string vendor, string name, int tdp, string sockets, decimal coast)
        {
            this.Coast = coast;
            this.Name = name;
            this.Sockets = sockets;
            this.TDP = tdp;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.Fans.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " TDP:" + this.TDP + "W";
        }
    }
}
