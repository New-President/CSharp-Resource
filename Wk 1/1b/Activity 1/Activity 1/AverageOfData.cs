using System;
using System.IO;
namespace Activity_1
{
    internal class AverageOfData
    {
        static void Main(string[] args)
        {
            double total = 0;
            double counter = 0;
            using (StreamReader sr = new StreamReader("data(2).csv"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    total += Convert.ToInt32(line);
                    counter++;
                }
                double average = total / counter;
                Console.WriteLine("The average is " + average.ToString("0.00"));
            }
            AverageOfData.testingprogram();
            AverageOfData.testmark();
        }
        static void testingprogram()
        {
            string text = File.ReadAllText("testing.txt");
            Console.WriteLine(text);
            string[] lines = File.ReadAllLines("testing.txt");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
        static void testmark()
        {
            string[] csvLines = File.ReadAllLines("testmarks.csv");

            // Display the file contents together with average using a for loop 
            string[] heading = csvLines[0].Split(',');
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}", heading[0], heading[1], heading[2], "Average");
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] marks = csvLines[i].Split(',');
                double average = (Convert.ToDouble(marks[1]) + Convert.ToDouble(marks[2])) / 2;
                Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}", marks[0], marks[1], marks[2], average.ToString("0.00"));
            }
        }
    }
}
