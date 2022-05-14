using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_FareCalculatorApp
{
    internal class Fare
    {
        public double upToDistance { get; set; }
        public int Amount { get; set; }

        public Fare() { }
        public Fare(double d, int a)
        {
            upToDistance = d;
            Amount = a;
        }

        public override string ToString()
        {
            return "Distance travelled: " + upToDistance + " km" +
                   "\nFare to pay: $" + Convert.ToDouble(Amount)/100;
        }
    }
}
