using System;
namespace decoratorPatter
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Espresso";
        }
        public double Cost()
        {
            return 1.99;
        }

    }
}
