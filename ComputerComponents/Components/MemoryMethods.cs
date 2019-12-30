using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class Memory : IComponent, IWritable
    {
        public Memory()
        {
            this.Capacity = 0;
            this.Coast = 0;
            this.Frequency = 0;
            this.Generation = "";
            this.Name = "";
            this.Vendor = "";
        }
        public Memory(string vendor, string name, int capacity, string generation, int frequency, decimal coast)
        {
            this.Capacity = capacity;
            this.Coast = coast;
            this.Frequency = frequency;
            this.Generation = generation;
            this.Name = name;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.Memories.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Capacity + "Gb " + this.Frequency + "GHz " + this.Generation;
        }
    }
}
