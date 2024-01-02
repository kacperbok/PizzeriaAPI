using Microsoft.AspNetCore.Http.Features;
using System;

namespace BurgerAPI
{
    public static class OrderManager
    {
        public static Order CreateOrder()
        { 
            OrderBuilder builder = new OrderBuilder();
            return builder.GetOrder();
        }
        public static List<Order> GetOrdersList()
        {
            return OrderBuilder._ordersList;
        }
        public static Order GetOrderData(Guid orderId)
        {
            foreach (var item in OrderBuilder._ordersList)
            {
                if (item.Id.Equals(orderId))
                {
                    return item;
                }
            }
            return null;
        }
        public static void AddBurgerToOrder(Guid orderId, Burger burger)
        {
            if (OrderExists(orderId) == true)
            {
                foreach (var item in OrderBuilder._ordersList)
                {
                    if (item.Id.Equals(orderId))
                    {
                        item.ListOfBurgers.Add(burger);
                        item.totalPrice += burger.Price;
                    }
                }
            }
        }
        public static bool OrderExists(Guid orderId)
        {
            foreach (var item in OrderBuilder._ordersList)
            {
                if (item.Id.Equals(orderId))
                {
                    return true;
                }
            }
            Console.WriteLine("Order does not exists");
            return false;
        }
    }
}
