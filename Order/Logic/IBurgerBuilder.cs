namespace BurgerAPI
{
    public interface IBurgerBuilder
    {
        public static List<IngredientsEnum> _burgerIngredientsList;
        public const decimal PRICE = 0;
        public const string BURGER_NAME = null;

        public Burger GetBurger();
    }
}
