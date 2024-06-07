public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override double GetCost()
    {
        return base.GetCost() + 2.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }
}