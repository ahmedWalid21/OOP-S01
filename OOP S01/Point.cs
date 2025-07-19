using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
        {
            set
            {
                this.x = value;
            }
            get
            {
                return x;
            }
        }
        public double Y
        {
            set
            {
                this.y = value;
            }
            get
            {
                return y;
            }
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }



    }
}
