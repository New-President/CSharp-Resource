using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_CashCardApp
{
    internal class CashCard
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public CashCard() { }

        public CashCard(string i, double b)
        {
            Id = i;
            Balance = b;
        }

        public void TopUp(double amount)
        {
            Balance += amount;
        }

        public bool Deduct(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Id: " + Id +
                  "\nBalance: " + Balance;
        }


    }
}
