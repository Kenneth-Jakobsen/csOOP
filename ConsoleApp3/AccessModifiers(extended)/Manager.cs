using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Manager : Employee
    {
        public Manager(string v1, int v2, string v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public string V1 { get; }
        public int V2 { get; }
        public string V3 { get; }
    }
}
