using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomApp
{
    class Dog : Animal
    {
        public Dog(string n, double s) : base("Dog", n, s) { }

        public override void MakeSound()
        {
            Console.WriteLine(base.Name + ": Woof Woof!");
        }
        public override void Move()
        {
            Console.WriteLine(base.Name + ": running at " + base.Speed + " km per hour...");
        }

        public void WagTail()
        {
            Console.WriteLine(base.Name + "  wagging tail...");
        }
    }
}
