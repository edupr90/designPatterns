using System;
namespace decoratorPatter
{
    public class HouseBlend : Beverage
    {
        
        public HouseBlend()
        {
            description = "House Blend Cofee";
        }
        override public double Cost()
        {
            return .89;
        }
    }
}
