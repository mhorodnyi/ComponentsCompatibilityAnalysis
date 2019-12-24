using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerComponents.Interfaces
{
    public interface IComponent
    {
        int Id { get; set; }
        string Vendor { get; set; }
        string Name { get; set; }
        decimal Coast { get; set; }
    }
}
