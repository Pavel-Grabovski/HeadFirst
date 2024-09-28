namespace HeadFirst.Strategy.Duck;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I am flying!");
    }
}
