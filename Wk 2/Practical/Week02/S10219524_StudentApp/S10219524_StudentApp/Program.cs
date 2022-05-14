using System;
using System.Collections.Generic;
using System.IO;

namespace S10219524_StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating student object 1
            DateTime dob = new DateTime(2000, 10, 13);
            Student s1 = new Student(1, "John Tan", "88552211", dob);

            DateTime dob2 = new DateTime(2001, 11, 14);
            Student s2 = new Student(2, "John John", "83625183", dob2);

            DateTime dob3 = new DateTime(2002, 12, 13);
            Student s3 = new Student(3, "John Not John", "86969696", dob3);

            DateTime dob4 = new DateTime(2003, 1, 14);
            Student s4 = new Student(4, "John Is John", "99999999", dob4);

            DateTime dob5 = new DateTime(2004, 2, 14);
            Student s5 = new Student(5, "John Can John", "88888888", dob5);

            //Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", "ID", "Name", "Tel", "Date of Birth");
            //Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", s1.Id, s1.Name, s1.Tel, s1.DateOfBirth.ToString("dd/MM/yyyy"));
            //Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", s2.Id, s2.Name, s2.Tel, s2.DateOfBirth.ToString("dd/MM/yyyy"));
            //Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", s3.Id, s3.Name, s3.Tel, s3.DateOfBirth.ToString("dd/MM/yyyy"));
            //Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", s4.Id, s4.Name, s4.Tel, s4.DateOfBirth.ToString("dd/MM/yyyy"));
            //Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", s5.Id, s5.Name, s5.Tel, s5.DateOfBirth.ToString("dd/MM/yyyy"));

            List<Student> studentList = new List<Student>();
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            studentList.Add(s5);

            Program.DisplayOutput(studentList);
            studentList.Add(Program.GetStudent());
            Console.WriteLine("\nFrom new studentList:");
            Program.DisplayOutput(studentList);

            List<Student> studentList2 = new List<Student>();
            string[] newstudents = File.ReadAllLines("Students.csv");
            for (int i = 1; i < newstudents.Length; i++)
            {
                string[] newstudent_details = newstudents[i].Split(",");
                string[] DOB = newstudent_details[3].Split("/");
                Student s7 = new Student(Convert.ToInt32(newstudent_details[0]), newstudent_details[1], newstudent_details[2],new DateTime(Convert.ToInt32(DOB[2]), Convert.ToInt32(DOB[1]), Convert.ToInt32(DOB[0])));
                studentList2.Add(s7);
            }
            Console.WriteLine("\nFrom studentList2:");
            Program.DisplayOutput(studentList2);

        }

        public static void DisplayOutput(List<Student> sList)
        {
            Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", "ID", "Name", "Tel", "Date of Birth");
            for (int i = 0; i < sList.Count; i++)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-15} {3}", sList[i].Id, sList[i].Name, sList[i].Tel, sList[i].DateOfBirth.ToString("dd/MM/yyyy"));
            }
        }

        public static Student GetStudent()
        {
            Console.Write("Student ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Date of Birth (mm/dd/yyyy): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            
            Student s6 = new Student(ID, name, phone, date);

            return s6;
        }
    }
}
