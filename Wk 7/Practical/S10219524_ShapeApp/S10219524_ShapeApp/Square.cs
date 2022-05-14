using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_ShapeApp
{
    internal class Square : Shape
    {
        public double Length { get; set; }
        public Square() { Length = 1; }
        public Square(string c, double l) : base("Square", c)
        {
            Length = l;
            Color = c;
        }
        public override double FindArea()
        {
            return Length*Length;
        }
        public override double FindPerimeter()
        {
            return Length*4;
        }
        public override string ToString()
        {
            return base.ToString() + "\tLength: " + Length;
        }
    }
}
