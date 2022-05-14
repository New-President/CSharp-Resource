using System;
using System.Collections.Generic;
using System.Text;

namespace SavingsAccount
{
    internal class SavingsAccount
    {
        // private attributes
        private string accountNo;
        private string accountName;
        private double balance;

        // public properties
        public string AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        // default constructor – does not have parameters
        public SavingsAccount() { }

        // parameterized constructor – with parameters
        public SavingsAccount(string no, string name, double bal)
        {
            AccountNo = no;
            AccountName = name;
            Balance = bal;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            return false;
        }
        // to string method
        public override string ToString()
        {
            return "AccountNo: " + AccountNo +
                  "\tAccountName: " + AccountName +
                  "\tBalance: " + Balance;
        }
    }
}
