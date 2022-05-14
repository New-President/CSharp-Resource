using System;
using System.Collections.Generic;
using System.Text;

namespace CT
{
    internal class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public int ApllicableDiscount { get; set; }
        public Customer() { }
        public Customer(int id, string n, int ad)
        {
            CustId = id;
            Name = n;
            ApllicableDiscount = ad;
        }
        public virtual double ApplyDiscount(double cost)
        {
            return cost - (ApllicableDiscount/100) * cost;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
