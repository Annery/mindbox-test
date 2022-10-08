using EasyGeometry.Shapes;
using NUnit.Framework;

namespace EasyGeometry.Tests
{
    public class CircleTests
    {
        [Test]
        [TestCase(1, ExpectedResult = 3.141592653589793)]
        [TestCase(3.1, ExpectedResult = 30.190705400997917)]
        public double AreaIsCalculatedCorrectly(double radius) =>
            new Circle(radius).Area;
    }
}
