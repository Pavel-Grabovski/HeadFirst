namespace HeadFirst.TemplateMethod;

public class Tea : CaffeineBeverage
{
    public override void AddComponents()
    {
        Console.WriteLine("Adding lemon");

    }

    public override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }
}
