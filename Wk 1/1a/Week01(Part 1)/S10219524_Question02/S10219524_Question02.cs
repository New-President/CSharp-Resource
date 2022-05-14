using System;

namespace S10219524_Question02
{
    class S10219524_Question02
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double percent,discount;
                Console.Write("Enter amount   ($) : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (amount <= 100)
                {
                    percent = 0;
                }
                else if (amount > 100 && amount <= 500)
                {
                    percent = 5;
                }
                else if (amount > 500 && amount <= 1000)
                {
                    percent = 10;
                }
                else
                {
                    percent = 20;
                }
                discount = amount * (percent / 100);
                Console.WriteLine("Discount given (%) : " + percent);
                Console.WriteLine("Discount amount($) : " + Math.Round(discount,2) + "\n");
            }
        }
    }
}
