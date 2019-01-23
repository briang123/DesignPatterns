using System;

namespace Behavioral.Command
{
    /// <summary>
    /// Step 2: Create a request class
    /// </summary>
    public class Stock
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        //private const string Name = "ABC";
        //private const int Quantity = 10;

        public void Buy()
        {
            Console.WriteLine(@"Stock [Name: {0}, Quantity: {1}] bought", Name, Quantity);
        }

        public void Sell()
        {
            Console.WriteLine(@"Stock [Name: {0}, Quantity: {1}] sold", Name, Quantity);
        }
    }
}