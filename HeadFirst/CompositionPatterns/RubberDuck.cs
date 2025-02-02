namespace HeadFirst.CompositionPatterns;

public class RubberDuck : IQuackable
{
    private readonly Observable _observable;

    public RubberDuck()
    {
        _observable = new Observable(this);
    }

    public void Quack()
    {
        Console.WriteLine("Squeak");
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