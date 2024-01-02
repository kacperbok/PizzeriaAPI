namespace BurgerAPI
{
    public class BurgerDrwalaBuilder : BurgerBuilder
    {
        private static List<IngredientsEnum> BURGER_INGREDIENTS_LIST = new List<IngredientsEnum>
        {
            IngredientsEnum.Tomato,
            IngredientsEnum.Lettuce,
            IngredientsEnum.Meat,
            IngredientsEnum.Bacon,
            IngredientsEnum.Pickle   
        };
        private const decimal PRICE = (decimal)BurgersNameEnum.Drwala;
        private const string BURGER_NAME = nameof(BurgersNameEnum.Drwala);
        public BurgerDrwalaBuilder()
        {
            _burger.IngredientsList.AddRange(BURGER_INGREDIENTS_LIST);
            _burger.Price = PRICE;
            _burger.Name = BURGER_NAME;
            GetBurger();
        }
        public Burger GetBurger()
        { 
            return _burger;
        }
    }
}
