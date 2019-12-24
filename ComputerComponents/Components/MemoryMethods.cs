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
