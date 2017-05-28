using System;
namespace decoratorPatter
{
    public abstract class CondimentDecorator : Beverage
    {
        public CondimentDecorator()
        {
        }
        public abstract string GetDescription();
    }
}
