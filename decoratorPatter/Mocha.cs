using System;
namespace decoratorPatter
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        override public string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha"; 
        }
        override public double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
