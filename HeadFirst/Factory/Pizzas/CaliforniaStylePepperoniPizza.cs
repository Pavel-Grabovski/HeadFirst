namespace HeadFirst.Factory.Pizzas;

public class CaliforniaStylePepperoniPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza in California style");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza in California style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza in California style");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare pepperoni pizza in California style");
    }
}