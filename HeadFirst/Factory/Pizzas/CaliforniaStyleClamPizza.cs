namespace HeadFirst.Factory.Pizzas;

public class CaliforniaStyleClamPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake clam pizza in California style");
    }

    public override void Box()
    {
        Console.WriteLine("Box clam pizza in California style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut clam pizza in California style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare clam pizza in California style");
    }
}