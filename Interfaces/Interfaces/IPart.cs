using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    interface IPart
    {
        int PartCount { get; set; }
        double Price { get; set; }
        string PartName { get; set; }
        int Order { get; set; }
    }
}
