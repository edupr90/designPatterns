using System;

namespace decoratorPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
        }
    }
}
