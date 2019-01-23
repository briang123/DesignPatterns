namespace Behavioral.Command
{
    /// <inheritdoc />
    /// <summary>
    /// Step 3: Create concrete classes implementing the Order interface
    /// </summary>
    public class SellStock : IOrder
    {
        private readonly Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}