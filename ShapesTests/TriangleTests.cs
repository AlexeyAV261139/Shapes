using Shapes;

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
    }
}
