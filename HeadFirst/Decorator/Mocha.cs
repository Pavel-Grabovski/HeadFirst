namespace HeadFirst.Decorator;

public class Mocha : CondimentDecorator
{
    private decimal _cost = 0.20m;

    public Mocha(Beverage beverage)
    {
        Beverage = beverage;
        Description = "Mocha";
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