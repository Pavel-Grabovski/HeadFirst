namespace HeadFirst.Observer.JavaLegacy;

public interface IObserver
{
    public void Update(Observable observable, object? arg);
}
