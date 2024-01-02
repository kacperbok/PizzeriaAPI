using Microsoft.AspNetCore.Mvc;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("BurgerAPI")]
    public class OrderController : Controller
    {
        [HttpPost("CreateOrder")]
        public Order CreateOrder()
        {
            return OrderManager.CreateOrder();
        }

        [HttpGet("GetOrdersList")]
        public List<Order> GetOrdersList()
        { 
            return OrderManager.GetOrdersList();
        }

        [HttpGet("GetOrderData/{Id}")]
        public Order GetOrderData([FromRoute]Guid Id)
        {
            return OrderManager.GetOrderData(Id);
        }

        [HttpGet("AddBurger/{orderId}/{burgerName}")]
        public void AddBurger([FromRoute]Guid orderId, [FromRoute]BurgersNameEnum burgerName)
        {
            OrderManager.AddBurgerToOrder(orderId, BurgerManager.CreateBurger(burgerName));
        }
    }
}
