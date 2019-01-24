using System;

namespace Behavioral.Interpreter
{
    internal class Program
    {
        //Rule: Robert and John are male
        public static IExpression GetMaleExpression()
        {
            var robert = new TerminalExpression("Robert");
            var john = new TerminalExpression("John");

            return new OrExpression(robert, john);
        }

        //Rule: Julie is a married woman
        public static IExpression GetMarriedWomanExpression()
        {
            var julie = new TerminalExpression("Julie");
            var married = new TerminalExpression("Married");

            return new AndExpression(julie, married);
        }

        private static void Main()
        {
            var isMale = GetMaleExpression();
            var isMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? {0}", isMale.Interpret("John"));
            Console.WriteLine("Ken is male? {0}", isMale.Interpret("Ken"));
            Console.WriteLine("Julie is a married woman? {0}", isMarriedWoman.Interpret("Married Julie"));

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}