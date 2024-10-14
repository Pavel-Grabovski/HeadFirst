namespace HeadFirst.Decorator;

public class DarkRoast : Beverage
{
    private decimal _cost = 0.99m;
    public DarkRoast()
    {
        Description = "Dark Roast";
    }

    public override decimal Cost() => _cost;
}
