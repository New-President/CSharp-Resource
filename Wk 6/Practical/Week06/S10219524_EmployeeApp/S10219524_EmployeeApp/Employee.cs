using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_EmployeeApp
{
    abstract class Employee: IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee() { }
        public Employee(int id, string n)
        {
            Id = id;
            Name = n;
        }
        public abstract double CalculatePay();
        public override string ToString()
        {
            return "Id: " + Id + "\tName: " + Name;
        }
        public int CompareTo(Employee e)
        {
            if (Id > e.Id)
            {
                return 1;
            }
            else if (Id == e.Id)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
