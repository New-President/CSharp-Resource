using System;

namespace S10219524_EmployeeApp
{
    internal class FullTimeEmployee : Employee
    {
        public double BasicPay { get; set; }
        public double Allowance { get; set; }
        public FullTimeEmployee() : base() { } 
        public FullTimeEmployee(int id, string n, double dp, double a) : base(id, n)
        {
            Id = id;
            Name = n;
            BasicPay = dp;
            Allowance = a;
        }
        public override double CalculatePay()
        {
            return BasicPay + Allowance;
        }
        public override string ToString()
        {
            return base.ToString() + "\tBasic Pay: " + BasicPay + "\tAllowance: " + Allowance;
        }
    }
}
