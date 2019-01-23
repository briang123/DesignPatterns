using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Behavioral.Command
{
    /// <summary>
    /// Step 5: Use the Broker class to take and execute commands
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var abcStock = new Stock();

            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);

            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }

    }
}