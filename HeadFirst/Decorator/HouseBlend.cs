namespace HeadFirst.Decorator;

public class HouseBlend : Beverage
{
    private decimal _cost = 0.89m;
    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }

    public override decimal Cost() => _cost;
}