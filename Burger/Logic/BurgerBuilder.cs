namespace BurgerAPI
{
    public class BurgerBuilder : IBurgerBuilder
    {
        protected Burger _burger;
        protected List<IngredientsEnum> _defaultBurgerIngredients = new List<IngredientsEnum>
        {
            IngredientsEnum.Bun,
            IngredientsEnum.Sauce
        };
        public BurgerBuilder()
        {
            _burger = new Burger();
            _burger.IngredientsList.AddRange(_defaultBurgerIngredients);
        }
        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
