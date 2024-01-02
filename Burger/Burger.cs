namespace BurgerAPI
{
    public class Burger
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public List<IngredientsEnum> IngredientsList { get; private set; }

        public decimal Price { get; set; }
        public Burger()
        { 
            Id = Guid.NewGuid();
            IngredientsList = new List<IngredientsEnum>();
        }

    }
}
