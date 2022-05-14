using System;
using System.Collections.Generic; // for List

namespace S10219524_EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SalesEmployee> employeeList = new List<SalesEmployee>();

            employeeList.Add(new SalesEmployee(101, "Angie", 1200, 15000));
            employeeList.Add(new SalesEmployee(105, "Cindy", 1000, 12000));
            employeeList.Add(new SalesEmployee(108, "David", 1500, 20000));
            employeeList.Add(new SalesEmployee(112, "Jason", 3000, 30000));
            employeeList.Add(new SalesEmployee(127, "Vivian", 2000, 25000));

            Console.WriteLine("{0,-5} {1,-10} {2,-12} {3,12}", "Id", "Name", "Basic Salary", "Sales");

            for (int i = 0; i < employeeList.Count; i++)
            {
                SalesEmployee s = employeeList[i];
                Console.WriteLine("{0,-5} {1,-10} {2,-19:0.00} {3,-12:0.00}", s.Id, s.Name, s.BasicSalary, s.Sales);
            }
        }
    }
}
