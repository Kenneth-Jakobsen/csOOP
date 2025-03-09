using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_.Practical_exercise
{
    class Manager : Employee
    {
        public int ManagedTeamSize { get; private set; }
        public Manager(string name, int employeeID, string department, int managedTeamSize) : base(name, employeeID, department)
        {
            ManagedTeamSize = managedTeamSize;
        }

        public override void Work()
        {
            Console.WriteLine($"Managing a team of {ManagedTeamSize} employees");
        }
    }
}
