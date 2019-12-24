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
