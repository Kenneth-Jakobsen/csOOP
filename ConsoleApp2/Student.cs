using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        string? Name { get; set; }
        int Age { get; set; }
        string? Grade { get; set; }


        public Student()
        {
            Name = "Unknown";
            Age = 0;
            Grade = "Not graded";
        }

        public Student(string? name, int age)
        {
            Name = name;
            Age = age;
            Grade = "No graded";
        }

        public Student(string? name, int age, string? grade) : this(name, age)
        {
            Grade = grade;
        }
    }
}
