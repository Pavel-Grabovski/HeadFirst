namespace HeadFirst.ObserverJavaVersion;

public interface IObserver
{
    public void Update(Observable observable, object? arg);
}
