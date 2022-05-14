using System;
using System.Collections.Generic;

namespace S10219524_ShapeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circleList = new List<Circle>();
            InitCircleList(circleList);
            while (true)
            {
                Console.Write("---------------- M E N U --------------------\n[1] List all the circles\n[2] Display the areas of the circles\n[3] Display the perimeters of the circles\n[4] Change the size of a circle\n[5] Add a new circle\n[6] Delete a circle\n[7] Display circles sorted by area\n[0] Exit\n--------------------------------------------\nEnter your option : ");
                string option = Console.ReadLine();
                if (option == "0")
                {
                    Environment.Exit(0);
                }
                else if (option == "1")
                {
                    for (int i = 0; i < circleList.Count; i++)
                    {
                        Console.WriteLine("[{0}]  {1}", (i + 1), circleList[i].ToString());
                    }
                    Console.WriteLine("");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < circleList.Count; i++)
                    {
                        Console.WriteLine("{0} Area: {1}", circleList[i].ToString(), Math.Round(circleList[i].FindArea(), 2));
                    }
                    Console.WriteLine("");
                }
                else if (option == "3")
                {
                    for (int i = 0; i < circleList.Count; i++)
                    {
                        Console.WriteLine("{0} Area: {1}", circleList[i].ToString(), Math.Round(circleList[i].FindPerimeter(), 2));
                    }
                    Console.WriteLine("");
                }
                else if (option == "4")
                {
                    for (int i = 0; i < circleList.Count; i++)
                    {
                        Console.WriteLine("[{0}] {1}", (i + 1), circleList[i].ToString());
                    }
                    Console.Write("Enter a circle number: ");
                    int cNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Enter new radius: ");
                    double newRadius = Convert.ToDouble(Console.ReadLine());
                    circleList[cNum].Radius = newRadius;
                    Console.WriteLine("Radius successfully changed.\n");
                }
                else if (option == "5")
                {
                    Console.Write("Circle color: ");
                    string circleColor = Console.ReadLine();
                    Console.Write("Circle radius: ");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());
                    circleList.Add(new Circle(circleColor, circleRadius));
                    Console.WriteLine("New " + circleColor + " circle with radius " + circleRadius + "cm added.\n");
                }
                else if (option == "6")
                {
                    for (int i = 0; i < circleList.Count; i++)
                    {
                        Console.WriteLine("[{0}] {1}", (i + 1), circleList[i].ToString());
                    }
                    Console.Write("Enter circle number: ");
                    int cNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    circleList.Remove(circleList[cNum]);
                    Console.WriteLine("Circle removed.\n");
                }
                else if (option == "7")
                {
                    circleList.Sort();
                    foreach (Circle c in circleList)
                    {
                        Console.WriteLine(c.ToString() + " Area: " + Math.Round(c.FindArea(), 2));
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\nInavalid Option!\n");
                }
            }
        }
        static void InitCircleList(List<Circle> cList)
        {
            Circle circle1 = new Circle("Red", 20);
            Circle circle2 = new Circle("Green", 10);
            Circle circle3 = new Circle("Blue", 30);
            cList.Add(circle1);
            cList.Add(circle2);
            cList.Add(circle3);
        }
    }
}
