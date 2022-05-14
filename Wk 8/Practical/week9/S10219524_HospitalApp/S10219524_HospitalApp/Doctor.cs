using System;
using System.Collections.Generic;
using System.Text;

namespace S10219524_HospitalApp
{
    internal class Doctor : Person
    {
        public string Department { get; set; }
        public List<Patient> patientList { get; set; } = new List<Patient>();
        public Doctor(string nric, string n, string d) : base(nric, n)
        {
            Department = d;
        }
        public void AddPatient(Patient p)
        {
            patientList.Add(p);
        }
        public void RemovePatient(Patient p)
        {
            if (patientList.Contains(p))
            {
                patientList.Remove(p);
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\tDepartment: " + Department;
        }
    }
}
