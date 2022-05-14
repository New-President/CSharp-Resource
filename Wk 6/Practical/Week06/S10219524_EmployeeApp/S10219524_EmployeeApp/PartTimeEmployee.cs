using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_EmployeeApp
{
    internal class PartTimeEmployee : Employee
    {
        public double DailyRate { get; set; }
        public int DaysWorked { get; set; }
        public PartTimeEmployee() : base() { }
        public PartTimeEmployee(int id, string n, double dr, int dw) : base(id, n)
        {
            Id = id;
            Name = n;
            DailyRate = dr;
            DaysWorked = dw;
        }
        public override double CalculatePay()
        {
            return DailyRate * DailyRate;
        }
        public override string ToString()
        {
            return base.ToString() + "\tDaily Rate: " + DailyRate + "\tDays Worked: " + DaysWorked;
        }
    }
}
