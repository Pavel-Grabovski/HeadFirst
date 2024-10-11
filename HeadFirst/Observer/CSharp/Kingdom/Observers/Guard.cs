namespace HeadFirst.Observer.CSharp.Kingdom.Observers;

public class Guard : IObserver<Order>
{
    private IDisposable? unsubscriber;

    private readonly string _name;

    public Guard(string name)
    {
        _name = name;
        Console.WriteLine($"{_name} решил стать стражником!");
    }

    public void OnCompleted()
    {
        this.Unsubscribe();
    }

    public virtual void OnError(Exception error)
    {
        Console.WriteLine($"{this} получил ошибку <<{error.Message}>>");
    }

    public virtual void OnNext(Order order)
    {
        Console.WriteLine($"{this} получил приказ <<{order.Message}>> от {order.Signature}");
    }

    public virtual void Unsubscribe()
    {
        Console.WriteLine($"{this} отрекся от службы");

        unsubscriber?.Dispose();
    }

    public virtual void Subscribe(IObservable<Order> overlord)
    {
        if (overlord != null)
        {
            Console.WriteLine($"{nameof(Guard)} {_name} присягнул царю {overlord}(y)");
            unsubscriber = overlord.Subscribe(this);
        }
    }

    public override string ToString()
    {
        return $"{nameof(Guard)}: {_name}";
    }
}
