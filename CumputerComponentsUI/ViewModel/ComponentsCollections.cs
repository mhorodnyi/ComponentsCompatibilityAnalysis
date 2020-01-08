using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerComponents.Models;

namespace CumputerComponentsUI.ViewModel
{
    static class ComponentsCollections
    {
        public static List<Motherboard> Motherboards
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.Motherboards.ToList();
                }
            }
        }
        public static List<Processor> CPUs
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.Processors.ToList();
                }
            }
        }
        public static List<GraphicalCard> GPUs
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.GraphicalCards.ToList();
                }
            }
        }
        public static List<PowerSupply> PowerSupplies
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.PowerSupplies.ToList();
                }
            }
        }
        public static List<Memory> Memories
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.Memories.ToList();
                }
            }
        }
        public static List<Fan> Fans
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.Fans.ToList();
                }
            }
        }
        public static List<HDD> HDDs
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.HDDs.ToList();
                }
            }
        }
        public static List<SSD> SSDs
        {
            get
            {
                using (ComputerComponentsEntities entities = new ComputerComponentsEntities())
                {
                    return entities.SSDs.ToList();
                }
            }
        }
    }
}
