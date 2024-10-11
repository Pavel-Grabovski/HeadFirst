namespace HeadFirst.Observer.CSharp.Kingdom.Observers;

public class Guard : IObserver<Order>
{
    private IDisposable? unsubscriber;

    private readonly string _name;

    public Guard(string name)
    {
        _name = name;
    }

    public void OnCompleted()
    {
        Console.WriteLine("Царь умер или отрекся от престола");
        this.Unsubscribe();
    }

    public virtual void OnError(Exception error)
    {
        Console.WriteLine(error.ToString());
    }

    public virtual void OnNext(Order order)
    {
        Console.WriteLine(order.Message);
    }

    public virtual void Unsubscribe()
    {
        unsubscriber?.Dispose();
    }

    public virtual void Subscribe(IObservable<Order> overlord)
    {
        if (overlord != null)
        {
            unsubscriber = overlord.Subscribe(this);

            Console.WriteLine($"{nameof(Guard)} {_name} присягнул {overlord}(y)");
        }
    }

    public override string ToString()
    {
        return $"{nameof(Guard)}: {_name}";
    }
}
