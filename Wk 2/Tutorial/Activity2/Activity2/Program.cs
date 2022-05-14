using System;
using System.Collections.Generic;
using System.IO;

namespace Activity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FPStudent> students = new List<FPStudent>();

            Console.WriteLine("Part 1");
            Console.Write("Enter student ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter CA1 mark: ");
            double ca1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter CA2 mark: ");
            double ca2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter ASG mark: ");
            double asg = Convert.ToDouble(Console.ReadLine());
            FPStudent student1 = new FPStudent(id, ca1, ca2, asg);
            double finalMark = student1.CalculateFinalMark();
            Console.WriteLine("Final mark: {0}", finalMark.ToString("0.0"));

            Console.WriteLine("\nPart 2");
            students.Add(new FPStudent("10011122C", 72.5, 80.0, 80.0));
            students.Add(new FPStudent("10013355B", 77.0, 88.5, 74.0));
            students.Add(new FPStudent("10012356H", 55.0, 66.0, 77.0));

            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", "Student ID", "CA1", "CA2", "ASG", "Final");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", students[i].StudentID, students[i].Ca1, students[i].Ca2, students[i].Assignment, students[i].CalculateFinalMark().ToString("0.0"));
            }

            Console.WriteLine("\nPart 3");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", "Student ID", "CA1", "CA2", "ASG", "Final");
            string[] studentlist = File.ReadAllLines("StudentMarks.csv");
            for (int i = 1;i < studentlist.Length;i++)
            {
                string[] row = studentlist[i].Split(",");
                FPStudent temp = new FPStudent(row[0], Convert.ToDouble(row[1]), Convert.ToDouble(row[2]), Convert.ToDouble(row[3]));
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", row[0], row[1], row[2], row[3], temp.CalculateFinalMark().ToString("0.0"));
            }

            Console.ReadKey();
        }
    }
}
