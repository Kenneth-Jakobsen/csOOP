using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FootballPlayer:IPlayable
    {
        public new void  Play()
        {
            Console.WriteLine("Playing football");
        }
    }
}
