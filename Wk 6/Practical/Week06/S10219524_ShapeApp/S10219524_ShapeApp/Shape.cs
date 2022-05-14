using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_ShapeApp
{
    abstract class Shape
    {
        public string Type { get; set; }
        public string Color { get; set; }

        public Shape() { }
        public Shape(string t, string c)
        {
            Type = t;
            Color = c;
        }

        public abstract double FindArea();
        public abstract double FindPerimeter();
        public override string ToString()
        {
            return "Type: " + Type + 
                   "\tColor: " + Color;
        }
    }
}
