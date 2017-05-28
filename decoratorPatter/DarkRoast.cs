using System;
namespace decoratorPatter
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }
        public double Cost()
        {
            return .99;
        }
    }
}
