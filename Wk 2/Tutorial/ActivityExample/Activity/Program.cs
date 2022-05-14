using System;
using System.Collections.Generic;

namespace ActivityExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //store student object in a list
            List<Student> studentslist = new List<Student>();

            //create an instance of object student
            Student s1 = new Student("John", "Don");
            Student s2 = new Student("A", "B");

            //change first name of s1
            s1.Firstname = "Matthias";//set first name
            Console.WriteLine(s1.Firstname);//get first name

            //Add student to studentlist
            studentslist.Add(s1);
            studentslist.Add(s2);

            //Display student in studentlist
            DisplayStudent(studentslist);

        }

        static void DisplayStudent(List<Student> slist)
        {
            foreach (Student s in slist)
            {
                Console.WriteLine(s.StudenFullName());
            }
        }
    }
}
