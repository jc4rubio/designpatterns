namespace WeatherMonitoringStation;

internal class PhoneDisplay(WeatherStation station) : IObserver, IDisplay
{
    private readonly WeatherStation station = station;

    private string temperature = string.Empty;

    public void Update()
    {
        this.temperature = this.station.GetTemperature().ToString();
    }

    public void Display()
    {
        Console.WriteLine($"Phone|Temperature: {temperature} ºC");
    }
}
