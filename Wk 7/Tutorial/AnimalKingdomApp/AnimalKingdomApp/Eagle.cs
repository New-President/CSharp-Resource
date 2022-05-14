using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomApp
{
    class Eagle : Bird
    {
        public Eagle(string n, double s, double w) : base(n, s, w) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + ": Scream!");
        }
        public override void Move()
        {
            Console.WriteLine(Name + ": fly diving at " + Speed + " km per hour...");
        }
    }
}
