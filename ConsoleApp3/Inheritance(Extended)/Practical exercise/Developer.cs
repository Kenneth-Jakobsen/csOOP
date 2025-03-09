using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_.Practical_exercise
{
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; private set; }
        public Developer(string name, int employeeID, string department, string programmingLanguage) : base(name, employeeID, department)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void Work()
        {
            Console.WriteLine($"Developing in {ProgrammingLanguage}");
        }
    }
}
