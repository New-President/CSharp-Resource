using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomApp
{
    class Ostrich : Bird
    {
        public Ostrich(string n, double s, double w) : base(n, s, w) { }

        public override void MakeSound()
        {
            Console.WriteLine(base.Name + ": Hiss....Boom!");
        }
        public override void Move()
        {
            Console.WriteLine(base.Name + ": sprinting at " + base.Speed + " km per hour...");
        }
    }
}
