using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomApp
{
    abstract class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string n, double s, double w) : base("Bird", n, s)
        {
            WingSpan = w;
        }

        public void BuildNest()
        {
            Console.WriteLine(Name + " building nest now...");
        }

        public override string ToString()
        {
            return base.ToString() + " \tWingspan(m): " + WingSpan;
        }

    }
}
