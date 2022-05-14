using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2
{
    internal class FPStudent
    {
        // attributes and properties
        private string studentID;
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private double ca1;
        public double Ca1
        {
            get { return ca1; }
            set { ca1 = value; }
        }

        private double ca2;
        public double Ca2
        {
            get { return ca2; }
            set { ca2 = value; }
        }

        private double assignment;
        public double Assignment
        {
            get { return assignment; }
            set { assignment = value; }
        }

        public FPStudent(string id, double ca1, double ca2, double asg)
        {
            StudentID = id;
            Ca1 = ca1;
            Ca2 = ca2;
            Assignment = asg;
        }

        // other method
        public double CalculateFinalMark()
        {
            double final = Ca1 * 0.3 + Ca2 * 0.3 + Assignment * 0.4;
            return final;
        }
    }
}
