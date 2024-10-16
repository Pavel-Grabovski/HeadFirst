namespace HeadFirst.Factory.Pizzas;

public class ChicagoStyleCheesePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza in Chicago style");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza in Chicago style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza in Chicago style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare cheese pizza in Chicago style");
    }
}