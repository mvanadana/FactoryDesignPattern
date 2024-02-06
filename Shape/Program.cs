using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape square = ShapeFactory.CreateSquare(10);

            double area = square.area();
            double perimeter = square.perimeter();
            Console.WriteLine("Area "+area);
            Console.WriteLine("Perimeter "+perimeter);

            IShape circle = ShapeFactory.CreateCircle(5);
            double CircleArea = circle.area();
            Console.WriteLine(CircleArea);
            

        }
    }
}
