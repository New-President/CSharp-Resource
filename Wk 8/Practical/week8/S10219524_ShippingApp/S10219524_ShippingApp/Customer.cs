using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_ShippingApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public ShippingAddr Addr { get; set; }
        public Customer() { }
        public Customer(string n, string t, ShippingAddr sa)
        {
            Name = n;
            Tel = t;
            Addr = sa;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\tTel: " + Tel + "\tAddress: " + Addr;
        }
    }
}
