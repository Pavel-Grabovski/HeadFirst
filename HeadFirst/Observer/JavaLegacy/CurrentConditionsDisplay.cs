namespace HeadFirst.Observer.JavaLegacy;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    Observable _observable;

    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(Observable observable)
    {
        _observable = observable;
        _observable.Register(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}°, F degrees and {_humidity} % humidity");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;

        Display();
    }

    public void Update(Observable observable, object? arg)
    {
        if (observable is WeatherData weatherData)
        {
            _temperature = weatherData.GetTemperature();
            _humidity = weatherData.GetHumidity();
            Display();
        }
    }
}