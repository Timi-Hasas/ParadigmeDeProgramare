namespace ProgrammingParadigms.Imperative
{
    public static class ImperativeCalculator
    {
        public static void Calculate()
        {
            Console.Write("First number: ");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            var secondNumber = double.Parse((Console.ReadLine()));

            Console.Write("Operation: ");
            var operation = char.Parse(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
                case '*': result = firstNumber * secondNumber; break;
                case '/': result = firstNumber / secondNumber; break;
            }
            Console.WriteLine(result);
        }
    }
}
