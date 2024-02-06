namespace Shape
{
    class Square : IShape
    {
        private double lengthofside;

        internal Square(double lengthofside)
        {
            this.lengthofside = lengthofside;
        }

        public double perimeter()
        {
            return 4 * lengthofside;
        }


        public double area()
        {
            return lengthofside * lengthofside;
        }
    }

}