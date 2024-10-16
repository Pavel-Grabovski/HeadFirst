namespace HeadFirst.Factory.Pizzas;

public class NYStyleCheesePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza in NY style");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza in NY style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza in NY style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare cheese pizza in NY style");
    }
}