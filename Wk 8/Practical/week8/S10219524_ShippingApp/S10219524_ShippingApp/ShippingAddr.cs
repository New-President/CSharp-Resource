using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_ShippingApp
{
    internal class ShippingAddr
    {
        public string Country { get; set; }
        public string Street { get; set; }
        public ShippingAddr() { }
        public ShippingAddr(string c, string s)
        {
            Country = c;
            Street = s;
        }
        public override string ToString()
        {
            return "Country: " + Country + "\tStreet: " + Street;
        }
    }
}
