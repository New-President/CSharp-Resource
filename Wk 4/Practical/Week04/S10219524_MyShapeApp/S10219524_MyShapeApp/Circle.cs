using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_MyShapeApp
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle() { }
        public Circle(double r)
        {
            Radius = r;
        }
        public virtual double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override string ToString()
        {
            return "Radius: " + Radius;
        }
    }
}
