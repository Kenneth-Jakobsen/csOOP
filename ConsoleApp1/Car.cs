using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make:{Make}, Model:{Model}, Year:{Year}");
        }
    }
}
