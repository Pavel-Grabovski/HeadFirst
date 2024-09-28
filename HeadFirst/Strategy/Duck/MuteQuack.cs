namespace HeadFirst.Strategy.Duck;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<<< Silence >>>");
    }
}
