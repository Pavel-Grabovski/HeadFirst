namespace HeadFirst.Observer.CSharp.Kingdom.Observable;

public class Tsar : IObservable<Order>
{
    private readonly string _name;

    private readonly List<IObserver<Order>> observers = new();

    public Tsar(string name)
    {
        _name = name;
        Console.WriteLine($"Царь {_name} помазан на царство");
    }

    public IDisposable Subscribe(IObserver<Order> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
            Console.WriteLine($"{_name} принял присягу у {observer}");
        }

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
        if(order is null)
        {
            Console.WriteLine("Order is null");
            return;
        }
        
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
        Console.WriteLine($"Царь {_name} отрекается");
        foreach (var observer in observers.ToArray())
            if (observers.Contains(observer))
                observer.OnCompleted();

        //observers.Clear();
    }
    public override string ToString()
    {
        return $"{nameof(Tsar)}: {_name}";
    }

}

