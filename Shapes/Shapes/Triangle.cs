using Shapes.Abstracts;
using Shapes.Extensions;

namespace Shapes.Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public bool IsRightAngle
            => (SideA * SideA + SideB * SideB).Equals4DigitPrecision(SideC * SideC) ||
               (SideA * SideA + SideC * SideC).Equals4DigitPrecision(SideB * SideB) ||
               (SideC * SideC + SideB * SideB).Equals4DigitPrecision(SideA * SideA);

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new Exception("Некорректная длинна сторон");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            CheckSidesRule();
        }

        private void CheckSidesRule()
        {
            bool first = SideA + SideB > SideC;
            bool second = SideA + SideC > SideB;
            bool third = SideB + SideC > SideA;

            if (!(first & second & third))
                throw new Exception("Треугольник не существует");
        }

        public override double GetSquare()
        {
            var perimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(
                perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
        }
    }
}
