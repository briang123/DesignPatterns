namespace Behavioral.Command
{
    /// <inheritdoc />
    /// <summary>
    /// Step 3: Create concrete classes implementing the Order interface
    /// </summary>
    public class SellStock : IOrder
    {
        private readonly Stock _stock;

        public SellStock(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Sell();
        }
    }
}