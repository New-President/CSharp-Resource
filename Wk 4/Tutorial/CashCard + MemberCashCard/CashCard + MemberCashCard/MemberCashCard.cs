using System;
using System.Collections.Generic;
using System.Text;

namespace CashCard___MemberCashCard
{
    class MemberCashCard : CashCard
    {
        // Attributes
        private int points;
        // Property
        public int Points { get; set; }
        // Constructors
        public MemberCashCard() : base() { }
        public MemberCashCard(string d, double b) : base(d, b) { }
        // Methods
        public void AddPoints(int p) { Points += p; }
        // overriding the Deduct() method
        public override bool Deduct(double amt)
        {
            if (base.Deduct(amt))
            {
                AddPoints((int)amt / 5);
                return true;
            }
            return false;
        }
        public bool DeductPoints(int p)
        {
            if (p <= Points)
            {
                Points -= p;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + "\tPoints: " + Points;
        }
    }
}
