using ProgrammingParadigms.OOP.Operations.Implementations;
using ProgrammingParadigms.OOP.Operations.Interfaces;

namespace ProgrammingParadigms.Flux
{
    public class EventCalculator
    {
        public delegate void OperationEventHandler(double firstNumber, double secondNumber);

        public event OperationEventHandler Sum;
        public event OperationEventHandler Subtract;
        public event OperationEventHandler Multiply;
        public event OperationEventHandler Divide;

        protected virtual void OnSum(double firstNumber, double secondNumber)
        {
            Sum(firstNumber, secondNumber);
        }

        protected virtual void OnSubtract(double firstNumber, double secondNumber)
        {
            Subtract(firstNumber, secondNumber);
        }

        protected virtual void OnMultiply(double firstNumber, double secondNumber)
        {
            Multiply(firstNumber, secondNumber);
        }

        protected virtual void OnDivide(double firstNumber, double secondNumber)
        {
            Divide(firstNumber, secondNumber);
        }

        public void Calculate(double firstNumber, double secondNumber, char op)
        {
            OperationEventHandler handler;
            handler = op switch
            {
                '+' => OnSum,
                '-' => OnSubtract,
                '*' => OnMultiply,
                '/' => OnDivide,
                _ => new OperationEventHandler(Sum),
            };

            handler.Invoke(firstNumber, secondNumber);
        }

        public class EventCalculatorSubscriber
        {
            public void OnSum(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber + secondNumber);
            }

            public void OnSubtract(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber - secondNumber);
            }

            public void OnMultiply(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber * secondNumber);
            }

            public void OnDivide(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
        }
    }
}
