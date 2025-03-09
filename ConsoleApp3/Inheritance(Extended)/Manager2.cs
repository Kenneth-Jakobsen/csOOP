using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_
{
    class Manager2 : Employee2
    {
        public int ManagedTeamSize { get; private set; }
        public Manager2(string name, int employeeID, string department, int managedTeamSize) : base(name, 25, employeeID)
        {
            ManagedTeamSize = managedTeamSize;
        }

        public void LeadTeam()
        {
            Console.WriteLine($"Leading a team of {ManagedTeamSize} people");
        }
    }
}
