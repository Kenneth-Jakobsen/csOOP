using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Polymorphism_Extended_
{
    class Employee : Person
    {
        public string Employer { get; private set; }
        public Employee(string name, int age, string employer) : base(name, age)
        {
            Employer = employer;
        }

        public new void Introduce()
        {
            Console.WriteLine($"Hello, I am {Name} and Im {Age} years old. I work at {Employer}");
        }
    }
}
