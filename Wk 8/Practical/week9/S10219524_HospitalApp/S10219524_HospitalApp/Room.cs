using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_HospitalApp
{
    internal class Room
    {
        public string Location { get; set; }
        public string WardClass { get; set; }
        public Room(string l, string wc)
        {
            Location = l;
            WardClass = wc;
        }
        public override string ToString()
        {
            return "Location: " + Location + "\tWard Class: " + WardClass;
        }
    }
}
