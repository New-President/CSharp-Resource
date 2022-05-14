using System;
using System.Collections.Generic;

namespace S10219524_ShippingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            InitCustomerList(customerList);
            ListCustomers(customerList);
        }
        static void InitCustomerList(List<Customer> customerList)
        {
            customerList.Add(new Customer("John Tan", "98501111", new ShippingAddr("Singapore", "Clementi Rd")));
            customerList.Add(new Customer("Amy Lim", "99991111", new ShippingAddr("Hong Kong", "Mong Kok Rd")));
            customerList.Add(new Customer("Tony Tay", "91112222", new ShippingAddr("Malaysia", "Malacca Rd")));
        }
        static void ListCustomers(List<Customer> customerList)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-1}", "Name", "Tel", "Country", "Street");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-1}", customer.Name, customer.Tel, customer.Addr.Country, customer.Addr.Street);
            }
        }
    }
}
