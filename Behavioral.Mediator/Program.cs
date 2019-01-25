using System;

namespace Behavioral.Mediator
{
    internal class Program
    {
        private static void Main()
        {
            var m = new ConcreteMediator();

            var c1 = new ConcreteColleage1(m);
            var c2 = new ConcreteColleage2(m);

            m.Colleage1 = c1;
            m.Colleage2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks!");

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}