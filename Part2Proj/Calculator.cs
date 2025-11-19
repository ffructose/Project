using Part2_s36444;

namespace Part2_s36444
{
    public class Calculator(double a, double b, char operation)
    {
        private readonly double A = a;
        private readonly double B = b;
        private readonly char Operation = operation;

        public double Calculate()
        {
            switch (Operation)
            {
                case '+':
                    return A + B;
                case '-':
                    return A - B;
                case '*':
                    return A* B;
                case '/':
                    if (B == 0) return double.NaN;
                    else return A / B;
                default:
                    return double.NaN;
            }
        }
    }

}