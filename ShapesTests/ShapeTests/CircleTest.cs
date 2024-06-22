using Shapes.Shapes;

namespace ShapesTests.Tests
{
    public class CircleTest
    {
        [Fact]
        public void NegativeRadius()
        {
            double radius = -10;

            Assert.Throws<Exception>(() =>
            {
                Circle circle = new Circle(radius);
            });
        }

        [Theory]
        [InlineData(1, 3.141593)]
        [InlineData(1.5, 7.068583)]
        [InlineData(5.95, 111.220234)]
        [InlineData(100, 31415.926536)]
        [InlineData(23.3333, 1710.41778)]
        public void CalculateSquare(double radius, double expected)
        {
            var circle = new Circle(radius);

            var square = circle.GetSquare();
            square = Math.Round(square, 6);

            Assert.Equal(expected, square);
        }
    }
}