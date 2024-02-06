namespace Shape
{
    public class Triangle : IShape
    {
        private double lengthofbase;
        private double height;

        internal Triangle(double lengthofbase,double height)
        {
            this.lengthofbase = lengthofbase;
            this.height = height;
        }

        public double area()
        {
            return height * lengthofbase;
        }

        public double perimeter()
        {
            return 3 * lengthofbase;
        }
    }
}