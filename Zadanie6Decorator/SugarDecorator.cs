public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override double GetCost()
    {
        return base.GetCost() + 1.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sugar";
    }
}