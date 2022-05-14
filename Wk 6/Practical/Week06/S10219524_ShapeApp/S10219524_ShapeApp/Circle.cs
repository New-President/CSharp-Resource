using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_ShapeApp
{
    internal class Circle : Shape, IComparable<Circle>
    {
        public double Radius { get; set; }
        public Circle() { Radius = 1.0; }
        public Circle(string c, double r) : base("Circle", c)
        {
            Radius = r;
        }
        public override double FindArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double FindPerimeter()
        {
            return Math.PI * 2 * Radius;
        }
        public override string ToString()
        {
            return base.ToString() + "\tRadius: " + Radius;
        }

        public int CompareTo(Circle c)
        {
            if (Radius > c.Radius)
            {
                return 1;
            }
            else if (Radius == c.Radius)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
