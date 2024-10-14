namespace HeadFirst.Decorator;

public class Whip : CondimentDecorator
{
    private decimal _cost = 0.10m;

    public Whip(Beverage beverage)
    {
        Beverage = beverage;
        Description = "Whip";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + _cost;
    }

    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, {Description}";
    }
}
