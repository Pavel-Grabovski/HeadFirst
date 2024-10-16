namespace HeadFirst.Factory.Pizzas;

public class NYStyleVeggiePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake veggie pizza in NY style");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza in NY style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut veggie pizza in NY style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare veggie pizza in NY style");
    }
}