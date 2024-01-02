namespace BurgerAPI
{
    public class OrderBuilder
    {
        private Order _order;
        public static List<Order> _ordersList = new List<Order>();
        public OrderBuilder() 
        {
            _order = new Order();
            _ordersList.Add(_order);
        }
        public Order GetOrder()
        {
            return _order;
        }
    }
}
