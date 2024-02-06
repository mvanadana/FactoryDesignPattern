using System;

namespace Shape
{
    public class Circle:IShape
    {
        private double radius;

        internal Circle(double radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            return 3.14 * radius * radius;
        }

        public double perimeter()
        {
            double originalValue = 2 * 3.14 * radius;
            double roundedValue = Math.Round(originalValue, 1);
            return roundedValue;
        }
    }
}