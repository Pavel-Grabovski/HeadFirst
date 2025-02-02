namespace HeadFirst.CompositionPatterns;

public class Flock : IQuackable
{
    List<IQuackable> quackers = new List<IQuackable>();
    
    List<IQuackable> _duck = new List<IQuackable>();

    public void Add(IQuackable quacker)
    {
        quackers.Add(quacker);
    }

    public void NotifyObservers() { }

    public void Quack()
    {
        IEnumerator<IQuackable> iterator = quackers.GetEnumerator();
        while (iterator.MoveNext())
        {
            IQuackable quacker = iterator.Current;
            quacker.Quack();
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        IEnumerator<IQuackable> iterator = quackers.GetEnumerator();
        while (iterator.MoveNext())
        {
            IQuackable quacker = iterator.Current;
            quacker.RegisterObserver(observer);
        }
    }
}
