using System;
namespace decoratorPatter
{
    public class HouseBlend : Beverage
    {
        
        public HouseBlend()
        {
            description = "House Blend Cofee";
        }
        public double Cost()
        {
            return .89;
        }
    }
}
