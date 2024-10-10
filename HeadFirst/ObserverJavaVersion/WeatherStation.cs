namespace HeadFirst.ObserverJavaVersion;

public static class WeatherStation
{
    public static void Start()
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new(weatherData);

        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);

        
        weatherData.Remove(currentDisplay);

        weatherData.SetMeasurements(45, 67, 23.2f);

    }
}
