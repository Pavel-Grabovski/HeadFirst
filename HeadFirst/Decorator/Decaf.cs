namespace HeadFirst.Decorator;

public class Decaf : Beverage
{
    private decimal _cost = 1.05m;
    public Decaf()
    {
        Description = "Decaf";
    }

    public override decimal Cost() => _cost;
}