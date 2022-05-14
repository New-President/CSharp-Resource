using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_HospitalApp
{
    internal class Patient : Person
    {
        public Room WardedAt { get; set; }
        public Patient(string nric, string n, Room wa): base(nric, n)
        {
            WardedAt = wa;
        }
        public override string ToString()
        {
            return base.ToString() + "\tWard Room: " + WardedAt;
        }
    }
}
