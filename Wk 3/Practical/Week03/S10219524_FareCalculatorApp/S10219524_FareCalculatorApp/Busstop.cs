using System;

namespace S10219524_FareCalculatorApp
{
    internal class BusStop
    {
        public double Distance { get; set; }
        public string Code { get; set; }
        public string Road { get; set; }
        public string Description { get; set; }

        public BusStop() { }
        public BusStop(double d, string c, string r, string desc)
        {
            Distance = d;
            Code = c;
            Road = r;
            Description = desc;
        }

        public override string ToString()
        {
            return String.Format("{0,-15} {1,-14} {2,-23} {3,-15}", Distance, Code, Road, Description);
        }
    }
}
