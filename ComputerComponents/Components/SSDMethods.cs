using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class SSD : IComponent, IWritable
    {
        public SSD()
        {
            this.Capacity = 0;
            this.Coast = 0;
            this.Interface = "";
            this.Name = "";
            this.ReadSpeed = 0;
            this.Vendor = "";
            this.WriteSpeed = 0;
        }
        public SSD(string vendor, string name, int capacity, string connectionInterface, int readSpeed, int writeSpeed, decimal coast)
        {
            this.Capacity = capacity;
            this.Coast = coast;
            this.Interface = connectionInterface;
            this.Name = name;
            this.ReadSpeed = readSpeed;
            this.Vendor = vendor;
            this.WriteSpeed = writeSpeed;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.SSDs.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Capacity + "Gb ";
        }
    }
}
