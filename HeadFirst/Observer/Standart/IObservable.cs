namespace HeadFirst.Observer.Standart;

public interface IObservable
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}