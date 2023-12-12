using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPatternBuilder.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder burgerBuilder;

        public BurgerDirector(IBurgerBuilder burgerBuilder)
        {
            this.burgerBuilder = burgerBuilder;
        }

        public void BuildDefault()
        {
            burgerBuilder
                .AddCheese()
                .AddTomato()
                .AddPickles();
        }

        public void BuildWithBacon()
        {
            burgerBuilder
                .AddTomato()
                .AddBacon()
                .AddLetuce();
        }
    }
}
