namespace HeadFirst.Factory;

public class ClamPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Bake clam pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box clam pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut clam pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine("Prepare clam pizza");
    }
}