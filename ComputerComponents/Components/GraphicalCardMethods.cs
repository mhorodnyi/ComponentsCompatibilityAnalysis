﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class GraphicalCard : IComponent, IWritable
    {
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
