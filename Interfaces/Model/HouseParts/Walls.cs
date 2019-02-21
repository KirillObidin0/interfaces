using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model.HouseParts
{
    class Walls:IPart
    {
        public int PartCount { get; set; }
        public double Price { get; set; }
        public string PartName { get; set; }
        public int Order { get; set; }
    }
}
