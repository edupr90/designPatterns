using System;
namespace decoratorPatter
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Espresso";
        }
        override public double Cost()
        {
            return 1.99;
        }

    }
}
