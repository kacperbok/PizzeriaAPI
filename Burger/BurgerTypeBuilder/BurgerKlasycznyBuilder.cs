namespace BurgerAPI
{
    public class BurgerKlasycznyBuilder : BurgerBuilder
    {
        private static List<IngredientsEnum> BURGER_INGREDIENTS_LIST = new List<IngredientsEnum>
        {
            IngredientsEnum.Tomato,
            IngredientsEnum.Lettuce,
            IngredientsEnum.Meat,
            IngredientsEnum.Bacon,
            IngredientsEnum.Pickle
        };
        private const decimal PRICE = (decimal)BurgersNameEnum.Klasyczny;
        private const string BURGER_NAME = nameof(BurgersNameEnum.Klasyczny);
        public BurgerKlasycznyBuilder()
        {
            _burger.IngredientsList.AddRange(BURGER_INGREDIENTS_LIST);
            _burger.Price = PRICE;
            _burger.Name = BURGER_NAME;
            GetBurger();
        }
       
    }
}
