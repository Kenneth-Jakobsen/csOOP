using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        protected string Name { get; set; }


        public Animal(string name)
        {
            Name = name;
        }

        public void PrintName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
