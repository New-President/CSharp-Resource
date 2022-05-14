using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomApp
{
    class Human : Animal
    {
        public Human(string n, double s) : base("Human", n, s) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + ": is talking sense here...");
        }
        public override void Move()
        {
            Console.WriteLine(Name + ": running at " + Speed + " km per hour...");
        }

        public void PlayGames()
        {
            Console.WriteLine(Name + " playing a digital game...");
        }
    }
}
