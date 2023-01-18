namespace ProgrammingParadigms.Functional
{
    public class FunctionalCalculator
    {
        Func<double, double, double> Add = (x, y) => x + y;

        Func<double, double, double> Subtract = (x, y) => x - y;

        Func<double, double, double> Multiply = (x, y) => x * y;

        Func<double, double, double> Divide = (x, y) => x / y;

        Func<double, double, double> Operation(char op)
        {
            return op switch
            {
                '+' => Add,
                '-' => Subtract,
                '*' => Multiply,
                '/' => Divide,
                _ => Add,
            };
        }
        public double Calculate(double firstNumber, double secondNumber, char op)
            => Operation(op)(firstNumber, secondNumber);
    }
}
