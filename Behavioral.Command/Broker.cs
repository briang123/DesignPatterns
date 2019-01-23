using System.Collections.Generic;

namespace Behavioral.Command
{
    /// <summary>
    /// Step 4: Create command invoker class
    /// </summary>
    public class Broker
    {
        private readonly List<IOrder> _orderList = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            _orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orderList)
            {
                order.Execute();
            }

            _orderList.Clear();
        }
    }
}