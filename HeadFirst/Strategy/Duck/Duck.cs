namespace HeadFirst.Strategy.Duck;

public abstract class Duck
{
    private readonly IQuackBehavior _quackBehavior;
    private readonly IFlyBehavior _flyBehavior;

    public void performQuack()
    {
        _quackBehavior.Quack();
    }

    public void performFly()
    {
        _flyBehavior.Fly();
    }
}
