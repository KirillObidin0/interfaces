using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public enum Position { Manager, Worker }
    public interface IWorker
    {
        string FullName { get; set; }
        double Salary { get; set; }
        Position Position { get; }
        void PrintInfo();
        double CalculateSalary(TimeSpan time);
    }
}
