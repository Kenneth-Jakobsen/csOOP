using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Library
    {
        public static int TotalBooks;
         static Library()
        {
            TotalBooks = 0;
        }

        public static void AddBook()
        {
            TotalBooks ++;
        }
    }
}
