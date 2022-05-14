using System;
using System.Collections.Generic;

namespace CT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void ApplyDiscountToCustomers(List<Customer> customerList, int purchaseAmount)
        {
            Console.WriteLine("Entitled Discount per $1000: ");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Cust Id", "Cust Name", "Discount amt ($)");
            for (int i = 0; i < customerList.Count; i++)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10:0.00}", customerList[i].CustId, customerList[i].Name, (Convert.ToDouble(purchaseAmount) - customerList[i].ApplyDiscount(Convert.ToDouble(purchaseAmount))));
            }
        }
        public static void RedeemMemberFee(List<Customer> customerList)
        {
            Console.WriteLine("Members with unsuccessful deduction of membership fee:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Cust Id", "Cust Name", "Points");
            int fail = 0;
            for (int i = 0;i < customerList.Count;i++)
            {
                if (customerList[i] is Member)
                {
                    Member member = (Member)customerList[i];
                    if (member.RedeemPoints(100))
                    {
                        Console.WriteLine("{0,-10} {1,-10} {2,-10}", member.CustId, member.Name, member.Points);
                    }
                    else
                    {
                        fail++;
                    }
                }
            }
            if (fail > 0)
            {
                Console.WriteLine("There is {0} member with unsuccessful deduction of membership fee", fail);
            }
            else
            {
                Console.WriteLine("There is no member with unsuccessful deduction of membership fee.");
            }
        }
    }
}
