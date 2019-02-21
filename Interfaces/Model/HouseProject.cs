using Interfaces.Interfaces;
using Interfaces.Model.HouseParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    class HouseProject
    {
        public HouseProject()
        {
            CreateProject();
            team.CreateTeam();
        }
        List<IPart> Parts = new List<IPart>();
        List<ITask> Tasks = new List<ITask>();
        Team team = new Team();
        private Random rnd = new Random();
        public void CreateProject()
        {
            Basement basement = new Basement()
            {
                PartCount = 1,
                Price = rnd.Next(),
                PartName = "basement",
                Order = 0
            };
            Roof roof = new Roof()
            {
                PartCount = 1,
                Price = rnd.Next(),
                PartName = "roof",
                Order = 1
            };
            Walls walls = new Walls()
            {
                PartCount = rnd.Next(4, 12),
                Price = rnd.Next(),
                PartName = "wall",
                Order = 0
            };
        }
        private void CreateTasks()
        {
            foreach (IPart part in Parts.OrderBy(o=>o.Order))
            {
                for (int i = 0; i < part.PartCount; i++)
                {
                    Task task = new Task();
                    task.Part = part;
                    Tasks.Add(task);
                }
            }
        }
        public void StartBuilding()
        {
            int countWorkers = team.Workers.Count - 1;
            IWorker worker = team.Workers[rnd.Next(0, countWorkers)];
            ITask task = Tasks.Where(w => w.Status == Status.Create).FirstOrDefault();
            if(task != null)
            {

            }

        }
    }
}
