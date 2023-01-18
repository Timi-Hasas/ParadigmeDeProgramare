using ProgrammingParadigms.OOP.Operations.Interfaces;

namespace ProgrammingParadigms.OOP.Operations.Implementations
{
    public class MultiplyOperation : IOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
