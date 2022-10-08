using System;

namespace EasyGeometry.Shapes
{
    public sealed class Circle : IShape
    {
        public double Area { get; private set; }

        public Circle(double radius) =>
            Area = Math.PI * Math.Pow(radius, 2);
    }
}
