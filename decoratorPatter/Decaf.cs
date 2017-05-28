using System;
namespace decoratorPatter
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        override public double Cost()
        {
            return 1.05;
        }
    }
}
