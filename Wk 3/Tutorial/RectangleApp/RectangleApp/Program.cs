using System;
using System.IO;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(50, 100);
            Rectangle rect2 = new Rectangle(100, 250);

            Console.WriteLine(rect1.ToString());
            Console.WriteLine("Area: " + rect1.FindArea());
            Console.WriteLine("\nRect2\n" + "Parameter: " + rect2.FindParameter());
        }
    }
}
