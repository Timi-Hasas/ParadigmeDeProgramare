using ProgrammingParadigms.OOP.Operations.Implementations;
using ProgrammingParadigms.OOP.Operations.Interfaces;

namespace ProgrammingParadigms.OOP
{
    public class Calculator : ICalculator
    {
        private IOperation _operation;

        public double Calculate(double firstNumber, double secondNumber, char op)
        {
            SetOperation(op);

            return _operation.Calculate(firstNumber, secondNumber);
        }

        private void SetOperation(char op)
        {
            _operation = op switch
            {
                '+' => new SumOperation(),
                '-' => new SubtractOperation(),
                '*' => new MultiplyOperation(),
                '/' => new DivideOperation(),
                _ => new SumOperation(),
            };
        }
    }
}
