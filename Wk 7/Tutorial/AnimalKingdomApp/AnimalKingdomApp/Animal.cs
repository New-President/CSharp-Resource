using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomApp
{
    abstract class Animal
    {

        // properties
        public string Type { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }
        public Animal(string t, string n, double s)
        {
            Type = t;
            Name = n;
            Speed = s;
        }
        public abstract void MakeSound();

        public abstract void Move();

        public override string ToString()
        {
            return "Type: " + Type + "\tName: " + Name + " \tSpeed(km/h): " + Speed;
        }
    }
}
