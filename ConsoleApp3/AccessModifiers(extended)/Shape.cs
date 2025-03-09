using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AccessModifiers_extended_
{
    class Shape
    {
        private string _color;
        public string Color
        {
            get { return _color; }
        }
        protected double Area { get; set; }

        public Shape(string color)
        {
            _color = color;
        }


        public void GetColor()
        {
            Console.WriteLine($"The color of the shape is {_color}");
        }
    }
}
