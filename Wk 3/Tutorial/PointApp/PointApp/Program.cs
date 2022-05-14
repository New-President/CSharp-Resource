using System;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point ptA = new Point(2, 2);
            Point ptB = new Point(5, 5);
            Console.WriteLine("Distance: " + ptA.Distance(ptB));
        }
    }
}
