namespace HeadFirst.Factory.Pizzas;

public class CaliforniaStyleCheesePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza in California style");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza in California style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza in California style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare cheese pizza in California style");
    }
}