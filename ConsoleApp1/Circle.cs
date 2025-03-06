using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle(double radius) : Shape
    {
        public double Radius { get; set; } = radius;

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
