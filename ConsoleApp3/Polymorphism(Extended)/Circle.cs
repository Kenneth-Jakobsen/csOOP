using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Polymorphism_Extended_
{
    class Circle : Shape, IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
            Name = "Circle";
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public void GetInfo()
        {
            Console.WriteLine($"I am a {Name} with area: {Area()}");
        }
    }
}
