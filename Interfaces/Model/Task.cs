using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    class Task : ITask
    {
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public Status Status { get; set; }
        public IWorker Worker { get; set; }
        public IPart Part { get; set; }

        public void PrintInfo()
        {
            switch (Status)
            {
                case Status.Create:
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("-> ",Part.PartName);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case Status.Process:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-> ",Part.PartName);
                        Console.WriteLine("Begin: {0}",Begin);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case Status.Completed:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> ", Part.PartName);
                        Console.WriteLine("Begin: {0}/{1}", Begin,End);
                        Worker.PrintInfo();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }
        }
    }
}
