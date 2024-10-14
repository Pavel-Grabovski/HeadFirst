namespace HeadFirst.Decorator;

public class Soy : CondimentDecorator
{
    private decimal _cost = 0.15m;

    public Soy(Beverage beverage)
    {
        Beverage = beverage;
        Description = "Soy";
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