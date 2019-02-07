using System;

namespace Behavioral.Visitor
{
    public class Program
    {
        private static void Main()
        {
            var employees = new Employees();
            employees.Attach(new Clerk("John", 20000, 10));
            employees.Attach(new Director("Carol", 40000, 20));
            employees.Attach(new President("Jim", 60000, 30));

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
