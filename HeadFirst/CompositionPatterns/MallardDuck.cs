namespace HeadFirst.CompositionPatterns;

public class MallardDuck : IQuackable
{
    private readonly Observable _observable;

    public MallardDuck()
    {
        _observable = new Observable(this);
    }

    public void Quack()
    {
        Console.WriteLine("Quack");
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        _observable.NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observable.RegisterObserver(observer);
    }
}