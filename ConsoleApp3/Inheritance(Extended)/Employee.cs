using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_
{
    class Employee
    {
        public string Name { get; private set; }
        public int EmployeeID { get; private set; }
        public string Department { get; private set; }

        public Employee(string name, int employeeID, string department)
        {
            Name = name;
            EmployeeID = employeeID;
            Department = department;
        }
    }
}
