using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_2
{
    internal class Program
    {
        public static void Main()
        {
            Coordinate point = new Coordinate();
             
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine(point.z);
        }
    }

    struct Coordinate
    {
        public int x;
        public int y;
        public int z;
    }


}

