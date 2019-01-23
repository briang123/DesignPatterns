namespace Behavioral.Command
{
    /// <summary>
    /// Step 3: Create concrete classes implementing the Order interface
    /// </summary>
    public class BuyStock : IOrder
    {
        private readonly Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }
}