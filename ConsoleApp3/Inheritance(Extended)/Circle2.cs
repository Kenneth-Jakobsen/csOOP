using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_
{
    class Circle2 : Shape
    {
        public double Radius { get; set; }

        public Circle2(double radius)
        {
            Radius = radius;
            Name = "Circle";
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
