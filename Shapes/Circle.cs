using Shapes.Abstracts;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Значения радиуса меньше или равно нулю");
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double GetSquare()
            => Math.PI * Radius * Radius;        
    }
}
