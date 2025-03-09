using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_
{
    class Employee2 : Person
    {
        public int EmployeeID { get; private set; }
        public Employee2(string name, int age, int employeeID) : base(name, age)
        {
            EmployeeID = employeeID;
        }

        public void Work()
        {
            Console.WriteLine("Working hard");
        }

    }
}
