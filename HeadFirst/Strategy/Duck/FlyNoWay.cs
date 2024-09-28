namespace HeadFirst.Strategy.Duck;

public class FlyNoWay: IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("i can't fly!");
    }
}
