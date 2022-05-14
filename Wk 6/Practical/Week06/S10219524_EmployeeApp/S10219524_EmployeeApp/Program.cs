using System;
using System.Collections.Generic;

namespace S10219524_EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            FullTimeEmployee employee1 = new FullTimeEmployee(103, "John", 1500, 100);
            PartTimeEmployee employee2 = new PartTimeEmployee(101, "Mary", 50, 10);
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Sort();
            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine(employeeList[i].ToString());
            }
        }
    }
}
