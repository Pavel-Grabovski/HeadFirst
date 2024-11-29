namespace HeadFirst.TemplateMethod;

public class Coffee : CaffeineBeverageWithHook
{
    public override void AddComponents()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    public override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }
}
