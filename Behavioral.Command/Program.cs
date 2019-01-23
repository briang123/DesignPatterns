using System;

namespace Behavioral.Command
{
    /// <summary>
    /// Step 5: Use the Broker class to take and execute commands
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var stock = new Stock
            {
                Name = "ABC",
                Quantity = 10
            };

            var buyStockOrder = new BuyStock(stock);
            var sellStockOrder = new SellStock(stock);

            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }

    }
}