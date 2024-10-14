namespace HeadFirst.Decorator;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        Beverage = beverage;
        Description = "Soy";
    }

    public override decimal Cost()
    {
        decimal beverageCost = Beverage.Cost();

        if (Beverage.GetSize() == BeverageSizeEnum.Small)
        {
            beverageCost += beverageCost + 0.10m;
        }
        else if (Beverage.GetSize() == BeverageSizeEnum.Medium)
        {
            beverageCost += beverageCost + 0.15m;
        }
        else if (Beverage.GetSize() == BeverageSizeEnum.Large)
        {
            beverageCost += beverageCost + 0.20m;
        }

        return beverageCost;
    }

    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, {Description}";
    }
}