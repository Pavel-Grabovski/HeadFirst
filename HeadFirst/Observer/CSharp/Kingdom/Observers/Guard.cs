namespace HeadFirst.Observer.CSharp.Kingdom.Observers;

public class Guard : IObserver<Order>
{
    private IDisposable unsubscriber;

    public void OnCompleted()
    {
        Console.WriteLine("Царь умер или отрекся от престола");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine(error.ToString());
    }

    public void OnNext(Order order)
    {
        Console.WriteLine(order.Message);
    }

    public virtual void Unsubscribe()
    {
        unsubscriber.Dispose();
    }
}
