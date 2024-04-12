using Shapes;
using System.ComponentModel;

namespace ShapesTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 1)]
        [InlineData(-1, -1, -1)]
        [InlineData(1, -1, -1)]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void NegativeSide(double sideA, double sideB, double sideC)
        {
            Assert.Throws<Exception>(() =>
            {
                var triangle = new Triangle(sideA, sideB, sideC);
            });
        }

        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(10, 5, 2)]
        [InlineData(3, 8, 3)]
        public void SidesRule(double sideA, double sideB, double sideC)
        {
            Assert.Throws<Exception>(() =>
            {
                var triangle = new Triangle(sideA, sideB, sideC);
            });               
        }

        [Theory]
        [InlineData(2, 2, 3, 1.984313)]
        [InlineData(3, 2, 3, 2.828427)]
        [InlineData(10, 8, 3, 9.921567)]
        public void CalculateSquare(
            double sideA,
            double sideB,
            double sideC,
            double expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var square = triangle.GetSquare();
            square = Math.Round(square, 6);

            Assert.Equal(expected, square);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(19, 180, 181, true)]
        [InlineData(55.3333, 379.4984, 383.5112136057, true)]
        public void IsRightAnglesTest(double sideA, double sideB, double sideC, bool expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngle = triangle.IsRightAngle;

            Assert.Equal(expected, isRightAngle);
        }
    }
}
