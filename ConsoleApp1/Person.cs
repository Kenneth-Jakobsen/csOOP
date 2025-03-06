using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        private protected string Name;
        private protected int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person():this("Unknown", 0){}

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello my name is {Name}");
        }

        public void CelebrateBirthday()
        {
            Age++;
            Console.WriteLine($"Happy Birthday! You're now {Age} years old.");
        }

        public void UpdatePerson(Person person)
        {
            Age = person.Age;
        }



    }
}
