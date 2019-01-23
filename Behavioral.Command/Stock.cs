using System;

namespace Behavioral.Command
{
    /// <summary>
    /// Step 2: Create a request class
    /// </summary>
    public class Stock
    {
        private readonly string _name = "ABC";
        private readonly int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine(@"Stock [Name: {0}, Quantity: {1}] bought", _name, _quantity);
        }

        public void Sell()
        {
            Console.WriteLine(@"Stock [Name: {0}, Quantity: {1}] sold", _name, _quantity);
        }
    }
}