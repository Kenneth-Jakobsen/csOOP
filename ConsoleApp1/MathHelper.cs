using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class MathHelper
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"The sum is: {a+b}");
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"The sum is {a*b}");
        }

        public static void Divide(int a, int b)
        {
            Console.WriteLine($"The value is: {a/b}");
        }
    }
}
