using EasyGeometry.Shapes;
using NUnit.Framework;

namespace EasyGeometry.Tests
{
    public class TriangleTests
    {
        [Test]
        public void IsRectangularShouldRetunTrueForReactanglarTriange()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular);
        }

        [Test]
        [TestCase(2, 4, 5)]
        [TestCase(3, 3, 3)]
        public void IsRectangularShouldRetunFalseForNotReactanglarTriange(double side1, double side2, double side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            Assert.IsFalse(triangle.IsRectangular);
        }

        [Test]
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(4, 3, 5, ExpectedResult = 6)]
        [TestCase(5, 4, 3, ExpectedResult = 6)]
        public double AreaCalculationIndependentFromSidesOrder(double side1, double side2, double side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            return triangle.Area;
        }
    }
}