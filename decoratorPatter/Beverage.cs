using System;
namespace decoratorPatter
{
    public abstract class Beverage
    {
        protected string description = "Unknown";
        public Beverage()
        {
        }
        public string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }

}
