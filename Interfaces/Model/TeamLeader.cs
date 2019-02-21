using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    class TeamLeader : IWorker
    {
        public TeamLeader()
        {
            Position = Position.Manager;
        }
        public string FullName { get; set; }
        public double Salary { get; set; }

        public Position Position { get; private set; }

        public double CalculateSalary(TimeSpan time)
        {
            return time.TotalHours * Salary * 1.05;
        }

        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} ({1})", FullName, Position);
            Console.WriteLine("Salary: {0:0,000 KZT}", Salary);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
