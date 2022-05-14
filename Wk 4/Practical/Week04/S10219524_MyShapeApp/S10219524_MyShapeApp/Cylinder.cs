using System;

namespace S10219524_MyShapeApp
{
    internal class Cylinder : Circle
    {
        public double Length { get; set; }
        public Cylinder() : base() { }
        public Cylinder(double r, double l) : base(r)
        {
            Length = l;
            Radius = r;
        }
        public override double CalculateArea()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2) + Math.PI * 2 * Radius * Length;
        }
        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Length;
        }

        public override string ToString()
        {
            return base.ToString() + "\tLength: " + Length;
        }
    }
}
