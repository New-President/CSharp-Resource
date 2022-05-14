using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeApp
{
    internal class Square : Shape
    {
        public double Length { get; set; }
        public Square() : base()
        {
            Length = 1.0;
        }
        public Square(string c, double len) : base("Square", c)
        {
            Length = len;
        }
        // override the abstract method
        public override double FindArea()
        {
            return Length * Length;
        }
        public override string ToString()
        {
            return base.ToString() + "Length: " +Length;
        }

    }
}
