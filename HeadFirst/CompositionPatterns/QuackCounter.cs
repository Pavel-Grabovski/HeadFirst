namespace HeadFirst.CompositionPatterns;

public class QuackCounter : IQuackable
{
    private readonly IQuackable _duck;
    private static int numberOfQuacks;

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
    }

    public void Quack()
    {
        _duck.Quack();
        numberOfQuacks++;
    }
    public static int GetQuacks()
    {
        return numberOfQuacks;
    }

    public void RegisterObserver(IObserver observer)
    {
        _duck.RegisterObserver(observer);
    }

    public void NotifyObservers()
    {
        _duck.NotifyObservers();
    }
}
