using WindowsFormsAppPatternBuilder.DBCon;

namespace WindowsFormsAppPatternBuilder.BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger burger;

        public BurgerBuilder()
        {
            burger = new Burger();
        }

        public IBurgerBuilder AddBacon()
        {
            burger.Bacon = true;
            return this;
        }

        public IBurgerBuilder AddCheese()
        {
            burger.Cheese = true;
            return this;
        }

        public IBurgerBuilder AddLetuce()
        {
            burger.Letuce = true;
            return this;
        }

        public IBurgerBuilder AddPickles()
        {
            burger.Pickles = true;
            return this;
        }

        public IBurgerBuilder AddTomato()
        {
            throw new System.NotImplementedException();
        }

        public Burger GetBurger()
        {
            Burger burgerr = burger;
            burger = new Burger();
            return burger;
        }
    }
}
