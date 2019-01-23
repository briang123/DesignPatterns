namespace Behavioral.Command
{
    /// <inheritdoc />
    /// <summary>
    /// Step 3: Create concrete classes implementing the Order interface
    /// </summary>
    public class BuyStock : IOrder
    {
        private readonly Stock _stock;

        public BuyStock(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Buy();
        }
    }
}