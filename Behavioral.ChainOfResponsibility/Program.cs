using System;

namespace Behavorial.ChainOfResponsibility
{
    internal class Program
    {
        private static Approver GetChainOfApprovers()
        {
            var larry = new Director();
            var sam = new VicePresident();
            var tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            return larry;
        }

        private static void Main()
        {
            // Generate and process purchase requests
            var approvalChain = GetChainOfApprovers();

            var p = new Purchase { Number = 1, Amount = 350.00, Purpose = "Assets" };
            approvalChain.ProcessRequest(p);

            p = new Purchase { Number = 2, Amount = 32590.10, Purpose = "Project X" };
            approvalChain.ProcessRequest(p);

            p = new Purchase { Number = 3, Amount = 122100.00, Purpose = "Project Y" };
            approvalChain.ProcessRequest(p);

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}