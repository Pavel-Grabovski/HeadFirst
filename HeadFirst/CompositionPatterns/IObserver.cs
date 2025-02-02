namespace HeadFirst.CompositionPatterns;

public interface IObserver
{
    public void Update(IQuackObservable quackable);
}
