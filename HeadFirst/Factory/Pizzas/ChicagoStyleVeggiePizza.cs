namespace HeadFirst.Factory.Pizzas;

public class ChicagoStyleVeggiePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake veggie pizza in Chicago style");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza in Chicago style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut veggie pizza in Chicago style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare veggie pizza in Chicago style");
    }
}