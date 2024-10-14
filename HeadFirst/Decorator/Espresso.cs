namespace HeadFirst.Decorator;

public class Espresso : Beverage
{
    private decimal _cost = 1.99m;
    public Espresso() 
    {
        Description = "Espresso";
    }

    public override decimal Cost() => _cost;
}