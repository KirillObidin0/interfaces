using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser;

namespace Interfaces.Model
{
    class Team
    {
        public Team()
        {
            Workers = new List<IWorker>();
        }
        public List<IWorker> Workers;
        private Random rnd = new Random();
        public void CreateTeam()
        {
            var user = GenerateUser.GetUser();
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.FullName = user.name.title + user.name.first;
            teamLeader.Salary = rnd.Next(3000, 10000);
            Workers.Add(teamLeader);

            for (int i = 0; i < rnd.Next(3,20); i++)
            {
                user = GenerateUser.GetUser();
                Worker worker = new Worker(Position.Worker);
                worker.FullName = user.name.title + user.name.first;
                worker.Salary = rnd.Next(1000, 5000);
                Workers.Add(worker);
            }
        }
    }
}
