namespace HeadFirst.Observer.Standart;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private IObservable _weatherData;

    public StatisticsDisplay(IObservable weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Statistics display: {_temperature}°, F degrees and {_humidity} % humidity");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;

        Display();
    }
}