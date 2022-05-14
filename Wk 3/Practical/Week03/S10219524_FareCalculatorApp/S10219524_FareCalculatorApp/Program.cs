using System;
using System.IO;
using System.Collections.Generic;

namespace S10219524_FareCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] DisplayBusses = File.ReadAllLines("bus_174(7).csv");
            string[] BusFare = File.ReadAllLines("distance-based-fare(7).csv");
            List<BusStop> Busses = new List<BusStop>();
            for (int i = 0; i < DisplayBusses.Length; i++)
            {
                string[] temp = DisplayBusses[i].Split(",");
                if (i == 0)
                {
                    Console.WriteLine("{0,-15} {1,-14} {2,-23} {3,-15}", temp[0], temp[1], temp[2], temp[3]);
                }
                else
                {
                    BusStop busstop = new BusStop(Convert.ToDouble(temp[0]), temp[1], temp[2], temp[3]);
                    Busses.Add(new BusStop(Convert.ToDouble(temp[0]), temp[1], temp[2], temp[3]));
                    Console.WriteLine(busstop.ToString());
                }
            }
            Console.Write("\nEnter boarding bus stop: ");
            string boarding = Console.ReadLine();
            Console.Write("Enter alighting bus stop: ");
            string alighting = Console.ReadLine();
            double distance = 0;
            Fare Fares = new Fare();
            foreach (BusStop busstop in Busses)
            {
                if (boarding == busstop.Code)
                {
                    distance -= busstop.Distance;
                }
                else if (alighting == busstop.Code)
                {
                    distance += busstop.Distance;
                }
            }
            for (int i = 1;i < BusFare.Length;i++)
            {
                string[] temp2 = BusFare[i].Split(",");
                if (distance <= Convert.ToDouble(temp2[0]))
                {
                    Fares = new Fare(distance,Convert.ToInt32(temp2[1]));
                    break;
                }
            }
            Console.WriteLine(Fares.ToString());

        }
    }
}
