using System;
using System.Collections.Generic;
using System.Text;

namespace PosApp
{
    internal class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }
        public Product(string c, string n, double p)
        {
            Code = c;
            Name = n;
            Price = p;
        }
        public override string ToString()
        {
            return "Code: " + Code + "\tName: " + Name + "\tPrice: " + Price;
        }
    }
}
