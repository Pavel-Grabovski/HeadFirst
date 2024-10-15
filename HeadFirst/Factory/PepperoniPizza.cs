namespace HeadFirst.Factory;

public class PepperoniPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box pepperoni pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare pepperoni pizza");
    }
}
