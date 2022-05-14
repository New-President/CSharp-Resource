using System;

namespace POIApp_S10219524
{
    internal class POI
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public POI() { }
        public POI(double lat, double lon, string n, string a)
        {
            Latitude = lat;
            Longitude = lon;
            Name = n;
            Address = a;
        }

        public double DistanceFrom(POI p)
        {
            double diffOfLat = Latitude - p.Latitude;
            double diffOfLon = Longitude - p.Longitude;
            double distance = Math.Sqrt(Math.Pow(diffOfLat, 2) + Math.Pow(diffOfLon, 2));
            return distance;
        }

        public override string ToString()
        {
            return String.Format("{0,-30} {1,-40} ({2}, {3})", Name, Address, Latitude, Longitude);
        }
    }
}
