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
        public string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha"; 
        }
        public double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
