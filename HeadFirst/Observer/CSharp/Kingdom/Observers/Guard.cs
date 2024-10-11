namespace HeadFirst.Observer.CSharp.Kingdom.Observers;

public class Guard : IObserver<Order>
{
    private readonly List<IObservable<Order>> observables= new ();
    //private IDisposable? unsubscriber;

    private readonly string _name;

    public Guard(string name)
    {
        _name = name;
        Console.WriteLine($"{_name} решил стать стражником!");
    }

    public void OnCompleted()
    {
        //this.Unsubscribe();
    }

    public virtual void OnError(Exception error)
    {
        Console.WriteLine($"{this} получил ошибку <<{error.Message}>>");
    }

    public virtual void OnNext(Order order)
    {
        Console.WriteLine($"{this} получил приказ <<{order.Message}>> от {order.Signature}");
    }

    public virtual void Unsubscribe(IObservable<Order> observable)
    {
        Console.WriteLine($"{this} отрекся от службы от {observable}");

        if (observables.Contains(observable))
        {
            observables.Remove(observable);
        }
        //unsubscriber?.Dispose();
    }

    public virtual void Subscribe(IObservable<Order> observable)
    {
        if (observable != null)
        {
            Console.WriteLine($"{nameof(Guard)} {_name} присягнул царю {observable}(y)");
            observable.Subscribe(this);
            observables.Add(observable);
        }
    }

    public override string ToString()
    {
        return $"{nameof(Guard)}: {_name}";
    }
}
