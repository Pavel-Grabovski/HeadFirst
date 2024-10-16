namespace HeadFirst.Factory.Pizzas;

public class ChicagoStylePepperoniPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza in Chicago style");
    }

    public override void Box()
    {
        Console.WriteLine("Box pepperoni pizza in Chicago style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza in Chicago style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare pepperoni pizza in Chicago style");
    }
}