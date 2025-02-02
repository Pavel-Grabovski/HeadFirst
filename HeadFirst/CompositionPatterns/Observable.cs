

namespace HeadFirst.CompositionPatterns;

public class Observable : IQuackObservable
{
    private readonly List<IObserver> observers = new List<IObserver>();
    private readonly IQuackObservable duck;

    public Observable(IQuackObservable duck)
    {
        this.duck = duck;
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
            observer.Update(duck);
    }
}
