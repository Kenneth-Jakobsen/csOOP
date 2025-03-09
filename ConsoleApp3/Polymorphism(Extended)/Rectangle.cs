using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Polymorphism_Extended_
{
    class Rectangle : Shape, IShape
    {
        public double Length { get; private set; } 
        public double Width { get; private set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            Name = "Rectangle";
        }

        public override double Area()
        {
            return Length * Width;
        }

        public void GetInfo()
        {
            Console.WriteLine($"I am a {Name} with area: {Area()}");
        }
    }
}
