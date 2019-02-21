using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    class Worker : IWorker
    {
        public Worker(Position position)
        {
            Tasks = new List<ITask>();
            this.Position = position;
        }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public Position Position { get; private set; }

        public List<ITask> Tasks;

        public double CalculateSalary(TimeSpan time)
        {
            return time.TotalHours * Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} ({1})",FullName,Position);
            Console.WriteLine("Salary: {0:0,000 KZT}",Salary);
        }
    }
}
