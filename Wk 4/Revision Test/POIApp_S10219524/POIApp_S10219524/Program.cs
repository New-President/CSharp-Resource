using System;
using System.Collections.Generic;
using System.IO;

namespace POIApp_S10219524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<POI> poiList = new List<POI>();
            string[] CSVfile = File.ReadAllLines("attractions(1).csv");
            for (int i = 0; i < CSVfile.Length; i++)
            {
                string[] temp = CSVfile[i].Split(",");
                poiList.Add(new POI(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]), temp[2], temp[3]));
            }
            DisplayPoint(poiList);
            poiList.Add(CreatePOI());
            Console.WriteLine("\nA new POI has been added to the list!\n");
            DisplayPoint(poiList);
            Console.WriteLine("");
            POI esplande = new POI();
            foreach (POI poi in poiList)
            {
                if (poi.Name == "Esplanade")
                {
                    esplande = poi;
                }
            }
            List<double> distances = new List<double>();
            for (int i = 0; i < poiList.Count; i++)
            {
                distances.Add(poiList[i].DistanceFrom(esplande));
            }
            distances.Sort();
            for (int i = 0; i < poiList.Count; i++)
            {
                if (poiList[i].DistanceFrom(esplande) == distances[1])
                {
                    Console.WriteLine("The nearest POI from Esplanade is {0}",poiList[i].Name);
                }
            }
            for (int i = 0;i < poiList.Count; i++)
            {
                if (poiList[i].DistanceFrom(esplande) == distances[distances.Count - 1])
                {
                    Console.WriteLine("The furthest POI from {0} is {1}", esplande.Name, poiList[i].Name);
                }
            }
        }

        static void DisplayPoint(List<POI> PoiList)
        {
            Console.WriteLine("{0,-30} {1,-40} ({2}, {3})", "Name", "Address", "Latitude", "Longitude");
            Console.WriteLine("{0,-30} {1,-40}  {2}, {3}", "----", "-------", "--------", "---------");
            for (int i = 0; i < PoiList.Count; i++)
            {
                Console.WriteLine(PoiList[i].ToString());
            }
        }

        static POI CreatePOI()
        {
            Console.WriteLine("\nCreate POIObject\n================");
            Console.Write("Latitude: ");
            double LAT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Longitude: ");
            double LON = Convert.ToDouble(Console.ReadLine());
            Console.Write("Name: ");
            string NAME = Console.ReadLine();
            Console.Write("Address: ");
            string ADDRESS = Console.ReadLine();
            return new POI(LAT, LON, NAME, ADDRESS);
        }
    }
}
