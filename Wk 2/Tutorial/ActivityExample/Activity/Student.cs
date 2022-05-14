using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityExample
{
    internal class Student
    {
        //characteristic: fields and propeties
        //short cut propfull and press tab 2x
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        //Constrcutor
        public Student(string fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }

        //Method
        public string StudenFullName()
        {
            return Firstname + " " + Lastname;
        }

    }
}
