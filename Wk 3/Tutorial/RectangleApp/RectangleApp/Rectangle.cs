namespace RectangleApp
{
    internal class Rectangle
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle() { }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public double FindArea()
        {
            return Width * Height;
        }

        public double FindParameter()
        {
            return Width*2 + Height*2;
        }

        public override string ToString()
        {
            return "Width: " + Width +
                   "\tHeight: " + Height;
        }
    }
}
