using System;

namespace SavingsAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create 2 objects, acc1 and acc2, of SavingsAccount class
            SavingsAccount acc1 = new SavingsAccount("111", "John", 200.0);
            SavingsAccount acc2 = new SavingsAccount("222", "Mary", 100.0);
            // withdraw $50 from acc1
            acc1.Withdraw(50);
            // print the balance of acc1
            Console.WriteLine("Balance of Account 1 : " + acc1.Balance);
            // deposit $100 to acc2
            acc2.Deposit(100);
            // print the detail of acc2
            Console.WriteLine(acc2.ToString());
        }
    }
}
