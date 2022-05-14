using System;
using System.Collections.Generic;
using System.Text;

namespace CT
{
    internal class Member : Customer
    {
        public int MembershipNo { get; set; }
        public int Points { get; set; }
        public Member() { }
        public Member(int id, string n, int ad, int mNo, int p) : base(id, n, ad)
        {
            MembershipNo = mNo;
            Points = p;
        }
        public override double ApplyDiscount(double cost)
        {
            return cost - (ApllicableDiscount / 100 + 0.05) * cost;
        }
        public bool RedeemPoints(int dp)
        {
            if (Points >= dp)
            {
                Points -= dp;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + "";
        }
    }
}
