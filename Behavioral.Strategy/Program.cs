using System;

namespace Behavioral.Strategy
{
    //https://www.tutorialspoint.com/design_pattern/strategy_pattern.htm
    internal class Program
    {
        private static void Main()
        {
            const int num1 = 10;
            const int num2 = 5;

            var context = new Context(new OperationAdd());
            Console.Write(@"{0} + {1} = {2}", num1, num2, context.ExecuteStrategy(num1, num2));

            context = new Context(new OperationSubtract());
            Console.Write(@"{0} - {1} = {2}", num1, num2, context.ExecuteStrategy(num1, num2));

            context = new Context(new OperationMultiply());
            Console.Write(@"{0} * {1} = {2}", num1, num2, context.ExecuteStrategy(num1, num2));

            context = new Context(new OperationDivide());
            Console.Write(@"{0} / {1} = {2}", num1, num2, context.ExecuteStrategy(num1, num2));

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }

    }
}
