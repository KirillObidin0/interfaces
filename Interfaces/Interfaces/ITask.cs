using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public enum Status { Create, Process, Completed}
    interface ITask
    {
        DateTime Begin { get; set; }
        DateTime End { get; set; }
        Status Status { get; set; }
        IWorker Worker { get; set; }
        IPart Part { get; set; }
        void PrintInfo();
    }
}
