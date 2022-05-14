using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp
{
    class Point
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point() { }

        public Point(int a, int b)
        {
            X = a;
            Y = b;
        }

        public double Distance(Point p)
        {
            double diffOfX = X - p.X;
            double diffOfY = Y - p.Y;
            double distance = Math.Sqrt(Math.Pow(diffOfY,2) + Math.Pow(diffOfX,2));
            return distance;
        }

        public override string ToString()
        {
            return "X: " + X +
                   "\nY: " + Y;
        }
    }
}
