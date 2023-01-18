using ProgrammingParadigms.Flux;
using ProgrammingParadigms.Functional;
using ProgrammingParadigms.Imperative;
using ProgrammingParadigms.OOP;
using static ProgrammingParadigms.Flux.EventCalculator;

namespace ProgrammingParadigms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            var secondNumber = double.Parse((Console.ReadLine()));

            Console.Write("Operation: ");
            var op = char.Parse(Console.ReadLine());

            //ImperativeCalculator.Calculate();

            FunctionalCalculator functionalCalculator = new FunctionalCalculator();
            functionalCalculator.Calculate(firstNumber, secondNumber, op);


            Calculator calculator = new Calculator();
            calculator.Calculate(firstNumber, secondNumber, op);

            EventCalculator eventCalculator = new EventCalculator();
            EventCalculatorSubscriber subscriber = new EventCalculatorSubscriber();

            eventCalculator.Sum += subscriber.OnSum;
            eventCalculator.Subtract += subscriber.OnSubtract;
            eventCalculator.Multiply += subscriber.OnMultiply;
            eventCalculator.Divide += subscriber.OnDivide;

            eventCalculator.Calculate(firstNumber, secondNumber, op);

        }
    }
}