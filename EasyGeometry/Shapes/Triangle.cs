using System;
using System.Linq;

namespace EasyGeometry.Shapes
{
    public sealed class Triangle : IShape
    {
        public bool IsRectangular { get; private set; }
        public double Area { get; private set; }

        private readonly double[] _sides;
        
        public Triangle(double side) : this(side, side, side)
        {
        }

        public Triangle(double side1, double side2, double side3)
        {
            _sides = new double[] { side1, side2, side3 };
            Area = CalculateArea(GetPerimeter());
            IsRectangular = GetLongestSide() == GetHypotenosis();
        }

        private double CalculateArea(double perimeter) =>
             Math.Sqrt(perimeter * (perimeter - _sides[0]) * (perimeter - _sides[1]) * (perimeter - _sides[2]));

        private double GetPerimeter() =>
            _sides.Sum() / 2;

        private double GetLongestSide() =>
            _sides.Max();

        private double GetSideIndex(double longestSide) =>
            Array.FindIndex(_sides, side => side == longestSide);

        private double GetHypotenosis()
        {
            var index = GetSideIndex(GetLongestSide());
            double sum = 0;
            for (int i = 0; i < _sides.Length; i++)
            {
                if (i != index)
                {
                    sum += Math.Pow(_sides[i], 2);
                }
            }
            return Math.Sqrt(sum);
        }
    }
}
