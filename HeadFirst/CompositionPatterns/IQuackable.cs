namespace HeadFirst.CompositionPatterns;

public interface IQuackable : IQuackObservable
{
    public void Quack();
}
