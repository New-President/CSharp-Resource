using System;
using System.IO;
using System.Collections.Generic;

namespace CarParkApp_S10219524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CarPark> CarParkList = new List<CarPark>();
            InItCarParkList(CarParkList);
            DisplayCarPark(CarParkList);
            int counter = 0;
            for (int i = 0;i < CarParkList.Count;i++)
            {
                if (CarParkList[i].Rate > 0.05)
                {
                    CarParkList[i].Rate += 0.002;
                    counter++;
                }
            }
            Console.WriteLine("\n{0} car park rates are increased by 0.2 cent.\n",counter);
            DisplayCarPark(CarParkList);
        }
        static void InItCarParkList(List<CarPark> cpList)
        {
            string[] file = File.ReadAllLines("CarPark_Rates.csv");
            for (int i = 1; i < file.Length; i++)
            {
                string[] line = file[i].Split(",");
                cpList.Add(new CarPark(line[0], line[1], Convert.ToDouble(line[2]), Convert.ToInt32(line[3])));
            }
        }
        static void DisplayCarPark(List<CarPark> cpList)
        {
            Console.WriteLine("{0,-30} {1,-25} {2, 10} {3,20}", "Car Park Name", "Category", "Rate($)", "Grace Period(mins)");
            for (int i = 0; i < cpList.Count; i++)
            {
                Console.WriteLine(cpList[i].ToString());
            }
        }
    }
}
