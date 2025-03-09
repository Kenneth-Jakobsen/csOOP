using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_
{
    class Rectangle:Shape
    {
        public double Length { get; private set; }
        public double Width { get; private set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            Name = "Rectangle";
        }

        public override double CalculateArea()
        {

            return Length * Width;
        }
    }
}
