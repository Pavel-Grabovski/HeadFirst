namespace HeadFirst.Observer.CSharp.Kingdom.Observable;

public class Tsar : IObservable<Order>
{
    private readonly List<IObserver<Order>> observers = new();

    public IDisposable Subscribe(IObserver<Order> observer)
    {
        if (!observers.Contains(observer))
            observers.Add(observer);

        return new Unsubscriber(observers, observer);
    }


    private class Unsubscriber : IDisposable
    {
        private List<IObserver<Order>> _observers;
        private IObserver<Order> _observer;

        public Unsubscriber(List<IObserver<Order>> observers, IObserver<Order> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

    public void IssueDecree(Order order)
    {
        foreach(IObserver<Order> observer in observers)
        {
            if (string.IsNullOrEmpty(order.Message))
                observer.OnError(new OrderException("Текст приказа пустой"));
            else
                observer.OnNext(order);
        }
    }

    public void Abdication()
    {
        foreach (var observer in observers)
            if (observers.Contains(observer))
                observer.OnCompleted();

        observers.Clear();
    }
}

