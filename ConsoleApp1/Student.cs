using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student(string name, int age, string grade):Person(name,age)
    {
        public string Grade { get; } = grade;

        public void Study()
        {
            Console.WriteLine("Studying hard for the next exam!");
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am in grade {Grade} and Im {Age} years old");
        }
    }
}
