namespace HeadFirst.Strategy.Duck;

public abstract class Duck
{
    protected private IQuackBehavior QuackBehavior;
    protected private IFlyBehavior FlyBehavior;

    public abstract void Display();

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}