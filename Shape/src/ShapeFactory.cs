namespace Shape
{
    public static class ShapeFactory
    {

        public static IShape CreateSquare(double lengthofside)
        {
            return new Square(lengthofside);
        }

        public static IShape CreateRectangle(double width, double height)
        {
            return new Rectangle(width, height);
        }

        public static IShape CreateTriangle(double lengthofbase, double height)
        {
            return new Triangle(lengthofbase, height);
        }
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

    }
}