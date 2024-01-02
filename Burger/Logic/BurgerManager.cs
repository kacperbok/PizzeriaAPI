namespace BurgerAPI
{
    public static class BurgerManager
    {
        public static Burger CreateBurger(BurgersNameEnum burgerName)
        {
            switch (burgerName)
            {
                case BurgersNameEnum.Drwala:
                    BurgerDrwalaBuilder burgerDrwalaBuilder = new BurgerDrwalaBuilder();
                    return burgerDrwalaBuilder.GetBurger();
                case BurgersNameEnum.Klasyczny:
                    BurgerKlasycznyBuilder burgerKlasycznyBuilder = new BurgerKlasycznyBuilder();
                    return burgerKlasycznyBuilder.GetBurger();
            }
            return null;
        }
    }
}
