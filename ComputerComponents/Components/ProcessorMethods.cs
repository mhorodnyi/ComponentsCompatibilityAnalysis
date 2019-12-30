using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Interfaces;

namespace ComputerComponents.Models
{
    partial class Processor : IComponent, IWritable
    {
        public Processor()
        {
            this.Coast = 0;
            this.Cores = 0;
            this.GraphicalCore = "";
            this.Name = "";
            this.Socket = "";
            this.TDP = 0;
            this.Threads = 0;
            this.Vendor = "";
        }
        public Processor(string vendor, string name, int cores, int threads, string socket, string graphicalCore, int tdp, decimal coast)
        {
            this.Coast = coast;
            this.Cores = cores;
            this.GraphicalCore = graphicalCore;
            this.Name = name;
            this.Socket = socket;
            this.TDP = tdp;
            this.Threads = threads;
            this.Vendor = vendor;
        }

        public void WriteNewRecord()
        {
            using (ComputerComponentsEntities context = new ComputerComponentsEntities())
            {
                context.Processors.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Vendor + " " + this.Name + " " + this.Socket + " " + this.Cores + "cores" + " " + this.Threads + "threads";
        }
    }
}
