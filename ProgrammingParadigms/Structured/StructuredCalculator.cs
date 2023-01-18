using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingParadigms.Structured
{
    public class StructuredCalculator
    {
        void Calculate()
        {
            double firstNumber, secondNumber;
            char operation;

            SetInput(out firstNumber, out secondNumber, out operation);
            GetOutput(firstNumber, secondNumber, operation);

            static void SetInput(out double firstNumber, out double secondNumber, out char operation)
            {
                Console.Write("First number: ");
                firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                secondNumber = double.Parse((Console.ReadLine()));
                Console.Write("Operation: ");
                operation = char.Parse(Console.ReadLine());
            }

            static double GetOutput(double firstNumber, double secondNumber, char operation)
            {
                double result = 0;
                switch (operation)
                {
                    case '+': result = firstNumber + secondNumber; break;
                    case '-': result = firstNumber - secondNumber; break;
                    case '*': result = firstNumber * secondNumber; break;
                    case '/': result = firstNumber / secondNumber; break;
                }

                return result;
            }
        }
    }
}
