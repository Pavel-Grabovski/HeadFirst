namespace HeadFirst.Factory.Pizzas;

public class VeggiePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake veggie pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut veggie pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare veggie pizza");
    }
}