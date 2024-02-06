namespace Shape
{
    public class Rectangle : IShape
    {
        private double length, width;
     
        internal Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double area()
        {
            return length * width;
        }

        public double perimeter()
        {
            return 2 * (length * width);
        }
    }
}