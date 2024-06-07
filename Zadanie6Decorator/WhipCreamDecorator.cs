public class WhipCreamDecorator : CoffeeDecorator
{
    public WhipCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override double GetCost()
    {
        return base.GetCost() + 3.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Whipped cream";
    }
}