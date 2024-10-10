namespace HeadFirst.Observer.JavaLegacy;

public class WeatherData : Observable
{
    private float _temperature;
    private float _humidity;
    private float _pressure;


    public void MeasurementsChanged()
    {
        SetChanged();
        Notify();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }

    public float GetTemperature() => _temperature;

    public float GetHumidity() => _humidity;

    public float GetPressure() => _pressure;
}