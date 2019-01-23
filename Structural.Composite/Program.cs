using System;

namespace Structural.Composite
{
    /// <summary>
    /// Step 2 - Use the Employee class to create and print employee hierarchy
    /// </summary>
    internal class Program
    {
        private static void Main()
        {

            var ceo = new Employee("John", "CEO", 20000);
            var headSales = new Employee("Robert", "Head Sales", 20000);
            var headMarketing = new Employee("Michael", "Head Marketing", 20000);

            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);

            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);

            ceo.Add(headSales);
            ceo.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            Console.WriteLine(ceo.GetEmployeeInfo());

            foreach (var headEmployee in ceo.GetSubordinates())
            {
                Console.WriteLine(headEmployee.GetEmployeeInfo());

                foreach (var employee in headEmployee.GetSubordinates())
                {
                    Console.WriteLine(employee.GetEmployeeInfo());
                }
            }

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
