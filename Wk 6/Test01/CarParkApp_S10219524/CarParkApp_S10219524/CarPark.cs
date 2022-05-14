using System;

namespace CarParkApp_S10219524
{
    internal class CarPark
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Rate { get; set; }
        public int GracePeriod { get; set; }

        public CarPark() { }
        public CarPark(string n, string c, double r, int gp)
        {
            Name = n;
            Category = c;
            Rate = r/100;
            GracePeriod = gp;
        }
        public double CalculateParking(int h, int min) // Got Wrong
        {
            if (h * 60 + min > GracePeriod)
            {
                return (h * 60 + min) * Rate;
            }
            return 0;
        }
        public override string ToString()
        {
            return String.Format("{0,-30} {1,-25} {2,10:0.000} {3,20}", Name, Category, Rate, GracePeriod);
        }
    }
}

