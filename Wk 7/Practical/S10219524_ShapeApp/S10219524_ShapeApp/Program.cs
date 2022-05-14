using System;
using System.Collections.Generic;

namespace S10219524_ShapeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            InitShapeList(shapeList);
            while (true)
            {
                Console.Write("---------------- M E N U --------------------\n[1] List all the shapes\n[2] Display the areas of the shapes\n[3] Display the perimeters of the shapes\n[4] Change the size of shapes\n[5] Add a new circle\n[6] Delete a circle\n[7] Display shapes sorted by area\n[0] Exit\n---------------------------------------------\nEnter your option : ");
                string option = Console.ReadLine();
                if (option == "0")
                {
                    break;
                }
                else if (option == "1")
                {
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        Console.WriteLine("[{0}]  {1}", (i + 1), shapeList[i].ToString());
                    }
                    Console.WriteLine("");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        Console.WriteLine("{0} Area: {1:0.00}", shapeList[i].ToString(), shapeList[i].FindArea());
                    }
                    Console.WriteLine("");
                }
                else if (option == "3")
                {
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        Console.WriteLine("{0} Perimeter: {1:0.00}", shapeList[i].ToString(), shapeList[i].FindPerimeter());
                    }
                    Console.WriteLine("");
                }
                else if (option == "4")
                {
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        if (shapeList[i] is Circle)
                        {
                            Circle c = (Circle)shapeList[i];
                            c.Radius += 5;
                        }
                        else
                        {
                            Square s = (Square)shapeList[i];
                            s.Length += 5;
                        }
                        Console.WriteLine("[" + (i + 1) + "] " + shapeList[i].ToString());
                    }
                }
                else if (option == "5")
                {
                    Console.Write("Circle color: ");
                    string circleColor = Console.ReadLine();
                    Console.Write("Circle radius: ");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());
                    shapeList.Add(new Circle(circleColor, circleRadius));
                    Console.WriteLine("New " + circleColor + " circle with radius " + circleRadius + "cm added.\n");
                }
                else if (option == "6")
                {
                    List<Shape> cl = new List<Shape>();
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        if (shapeList[i] is Circle)
                        {
                            cl.Add(shapeList[i]);
                        }
                    }
                    try
                    {
                        shapeList.Remove(cl[cl.Count-1]);
                        for (int i = 0; i < shapeList.Count; i++)
                        {
                            Console.WriteLine("[{0}]  {1}", (i + 1), shapeList[i].ToString());
                        }
                        Console.WriteLine("Circle removed.");
                    }
                    catch
                    {
                        Console.WriteLine("There are no more circle in the list.");
                    }
                    Console.WriteLine();
                }
                else if (option == "7")
                {
                    shapeList.Sort();
                    for (int i = 0; i < shapeList.Count; i++)
                    {
                        Console.WriteLine("{0} Area: {1:0.00}", shapeList[i].ToString(), Math.Round(shapeList[i].FindArea(), 2));
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\nInvalid Option!\n");
                }
            }
        }
        static void InitShapeList(List<Shape> shList)
        {
            Circle shape1 = new Circle("Red", 20);
            Square shape2 = new Square("Red", 10);
            Circle shape3 = new Circle("Green", 10);
            Square shape4 = new Square("Green", 20);
            Circle shape5 = new Circle("Blue", 30);
            Square shape6 = new Square("Blue", 30);
            shList.Add(shape1);
            shList.Add(shape2);
            shList.Add(shape3);
            shList.Add(shape4);
            shList.Add(shape5);
            shList.Add(shape6);
        }
    }
}
