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
            //Week07
            Shape newShape = new Circle("Pink",7);
            Circle newCircle = (Circle)newShape;
            List<Shape> shapesList = new List<Shape>();
            Shape s11 = new Circle("Red", 10.0);
            Shape s22 = new Square("Green", 20.0);
            shapesList.Add(s11);
            shapesList.Add(s22);
            ChangeShapeSize(shapesList);
        }
        static void ChangeShapeSize(List<Shape> shapesList)
        {
            foreach (Shape s in shapesList)
            {
                if (s is Circle)    // check if it is a Circle object
                {
                    Circle c = (Circle)s;   // downcast to Circle object
                    c.Radius += 5;
                }
                else if (s is Square)   // check if it is a Square object
                {
                    Square sq = (Square)s; // downcast to Square object
                    sq.Length += 5;
                }
            }
        }
    }
}
