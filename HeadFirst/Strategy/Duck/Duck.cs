namespace HeadFirst.Strategy.Duck;

public abstract class Duck
{
    protected private IQuackBehavior QuackBehavior;
    protected private IFlyBehavior FlyBehavior;

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }
}