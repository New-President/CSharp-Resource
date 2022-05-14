using System;
using System.Collections.Generic;

namespace ShapeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            Shape s1 = new Circle("Red", 10.0);
            Shape s2 = new Square("Blue", 10.0);
            Shape s3 = new Square("Black", 20.0);

            shapeList.Add(s1);
            shapeList.Add(s2);
            shapeList.Add(s3);

            foreach (Shape s in shapeList)
            {
                Console.WriteLine(s.ToString() + "\tArea: " + s.FindArea());
            }

        }
    }
}
