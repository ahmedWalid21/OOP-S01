using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal struct Point
    {
        public int x;
        public int y;
        //constructor: special method
        //            1. named like struct
        //            2.has no return type
        //CLR: will generate the parameterless constructor
        //constructor
        //  public Point()
        //  {

        // }
       public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public void printPoint()
        {
            Console.WriteLine($"({x}, {y})");
        }
        public override string ToString()
        {
            return $"( {x}, {y})";
        }


    }
}
