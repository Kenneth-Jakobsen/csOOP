using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Inheritance_Extended_
{
    class ElectricCar:Vehicle
    {
        new public void StartEngine()
        {
            Console.WriteLine("Electric Engine started");
        }
    }
}
