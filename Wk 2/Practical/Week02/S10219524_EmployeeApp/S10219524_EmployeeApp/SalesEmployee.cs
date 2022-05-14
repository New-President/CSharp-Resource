using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_EmployeeApp
{
    internal class SalesEmployee
    {
        // attributes and properties
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double basicSalary;
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        private double sales;
        public double Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        // constructor
        public SalesEmployee(int i, string n, double bSalary, double s)
        {
            Id = i;
            Name = n;
            BasicSalary = bSalary;
            Sales = s;
        }
    }
}

