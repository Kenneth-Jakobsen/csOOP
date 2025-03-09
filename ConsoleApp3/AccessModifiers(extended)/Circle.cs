using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AccessModifiers_extended_
{
    class Circle : Shape
    {
        private double _radius;
        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
            CalculateArea();
        }

        private void CalculateArea()
        {
            Area = Math.PI * _radius * _radius;
        }
    }
}
