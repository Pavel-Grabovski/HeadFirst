namespace HeadFirst.CompositionPatterns;

public interface IQuackObservable
{
    public void RegisterObserver(IObserver observer);
    public void NotifyObservers();
}
