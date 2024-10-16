namespace HeadFirst.Factory.Pizzas;

public class NYStylePepperoniPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza in NY style");
    }

    public override void Box()
    {
        Console.WriteLine("Box pepperoni pizza in NY style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza in NY style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare pepperoni pizza in NY style");
    }
}