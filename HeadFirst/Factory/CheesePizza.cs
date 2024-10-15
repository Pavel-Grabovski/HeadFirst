namespace HeadFirst.Factory;

public class CheesePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare cheese pizza");
    }
}
