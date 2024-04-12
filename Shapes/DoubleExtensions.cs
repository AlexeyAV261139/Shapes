namespace Shapes
{
    public static class DoubleExtensions
    {
        public static bool Equals4DigitPrecision(this double left, double right)
        {
            return Math.Abs(left - right) < 0.0001;
        }
    }
}
