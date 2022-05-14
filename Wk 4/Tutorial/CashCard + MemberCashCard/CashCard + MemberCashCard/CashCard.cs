using System;
using System.Collections.Generic;
using System.Text;

namespace CashCard___MemberCashCard
{
    class CashCard
    {
        // Attributes
        private string id;
        private double balance;
        // Properties
        public string Id { get; set; }
        public double Balance { get; set; }
        // Constructors
        public CashCard() { }
        public CashCard(string d, double b) { Id = d; Balance = b; }
        // Methods
        public void TopUp(double amt) { Balance += amt; }
        public virtual bool Deduct(double amt)
        {
            if (Balance >= amt)
            {
                Balance -= amt;
                return true;
            }
            return false;
        }
        public override string ToString() { return "Id: " + Id + "\tBalance: " + Balance; }
    }

}
