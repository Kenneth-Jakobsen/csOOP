﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Polymorphism_Extended_
{
    internal class FootballPlayer:IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing football");
        }
    }
}
