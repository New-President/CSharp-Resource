using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_HospitalApp
{
    internal class Person
    {
        public string NRIC { get; set; }
        public string Name { get; set; }
        public Person(string nric, string n)
        {
            NRIC = nric;
            Name = n;
        }
        public override string ToString()
        {
            return "NRIC: " + NRIC + "\tName: " + Name;
        }
    }
}
