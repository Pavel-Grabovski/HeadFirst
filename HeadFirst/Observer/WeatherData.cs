namespace HeadFirst.Observer;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers;

    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }

    public void NotifyObservers()
    {
        foreach(IObserver observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine($"Register observer {observer}");
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine($"Remove observer {observer}");

    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}