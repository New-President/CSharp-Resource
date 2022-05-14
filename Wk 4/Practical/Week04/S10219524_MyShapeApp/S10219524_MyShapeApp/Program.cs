using System;

namespace S10219524_MyShapeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Cylinder cylinder1 = new Cylinder(5, 10);
            while (true)
            {
                DisplayMenu();
                string options = Console.ReadLine();
                if (options == "1")
                {
                    Console.WriteLine("\n" + circle1.ToString());
                    Console.Write("Enter a new radius: ");
                    double radius2 = Convert.ToDouble(Console.ReadLine());
                    circle1.Radius = radius2;
                    Console.WriteLine("");
                }
                else if (options == "2")
                {
                    Console.WriteLine("\nRadius: " + cylinder1.Radius);
                    Console.Write("Enter a new radius: ");
                    double radius2 = Convert.ToDouble(Console.ReadLine());
                    cylinder1.Radius = radius2;
                    Console.WriteLine("");
                }
                else if (options == "3")
                {
                    Console.WriteLine("\nLength: " + cylinder1.Length);
                    Console.Write("Enter a new length: ");
                    double length2 = Convert.ToDouble(Console.ReadLine());
                    cylinder1.Length = length2;
                    Console.WriteLine("");
                }
                else if (options == "4")
                {
                    Console.WriteLine("\nArea of Circle: {0}\n", circle1.CalculateArea());
                }
                else if (options == "5")
                {
                    Console.WriteLine("\nSurface area of Cylinder: {0}\n", cylinder1.CalculateArea());
                }
                else if (options == "6")
                {
                    Console.WriteLine("\nVolume of Cylinder: {0}\n", cylinder1.CalculateVolume());
                }
                else if (options == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Option! Please select from 0-6!");
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("---------------- M E N U -----------------");
            Console.WriteLine("[1] Change the radius of circle");
            Console.WriteLine("[2] Change the radius of cylinder");
            Console.WriteLine("[3] Change the length of cylinder");
            Console.WriteLine("[4] Display the area of circle");
            Console.WriteLine("[5] Display the surface area of cylinder");
            Console.WriteLine("[6] Display the volume of cylinder");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter your option : ");
        }
    }
}
