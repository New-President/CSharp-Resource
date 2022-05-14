using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_StudentApp
{
    class Student
    {
        //Question 1
        //Complete the missing attributes & Properties and the incomplete student class constructor

        // attributes and properties
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        // constructor (behaviour, what can the product do)
        public Student(int i, string n, string t, DateTime dob)
        {
            Id = i;
            Name = n;
            Tel = t;
            DateOfBirth = dob;
        }
    }
}
