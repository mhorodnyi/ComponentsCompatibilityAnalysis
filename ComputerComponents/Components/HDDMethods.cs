using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class HDD : IComponent, IWritable
    {
        public HDD()
        {
            this.Capacity = 0;
            this.Coast = 0;
            this.Name = "";
            this.Vendor = "";
        }
        public HDD(string vendor, string name, int capacity, decimal coast)
        {
            this.Capacity = capacity;
            this.Coast = coast;
            this.Name = name;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.HDDs.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Capacity + "Gb";
        }
    }
}
