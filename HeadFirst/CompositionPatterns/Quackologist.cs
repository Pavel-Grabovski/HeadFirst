namespace HeadFirst.CompositionPatterns;

public class Quackologist : IObserver
{
    public void Update(IQuackObservable quackable)
    {
        Console.WriteLine($"Quackologist: {quackable} just quacked.");
    }
}
