namespace BurgerAPI
{
    public class Order
    {
        public Guid Id { get; private set; }
        public List<Burger> ListOfBurgers { get; private set; }
        public decimal totalPrice { get; set; }
        public Order() 
        {
            Id = Guid.NewGuid();
            ListOfBurgers = new List<Burger>();
        }
    }
}
