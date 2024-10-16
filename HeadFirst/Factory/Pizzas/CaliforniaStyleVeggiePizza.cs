namespace HeadFirst.Factory.Pizzas;

public class CaliforniaStyleVeggiePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake veggie pizza in California style");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza in California style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut veggie pizza in California style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare veggie pizza in California style");
    }
}