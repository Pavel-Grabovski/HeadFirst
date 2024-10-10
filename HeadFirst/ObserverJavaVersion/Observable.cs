namespace HeadFirst.ObserverJavaVersion;

public class Observable
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private bool _isChanged;

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(object arg)
    {
        if (_isChanged)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this, arg);
            }
        }
        _isChanged = false;
    }

    public void SetChanged()
    {
        _isChanged = true;
    }
}
