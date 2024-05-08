namespace WeatherMonitoringStation;

internal class WindowsDisplay(WeatherStation station) : IObserver, IDisplay
{
    private readonly WeatherStation station = station;

    private string temperature = string.Empty;

    public void Update()
    {
        this.temperature = this.station.GetTemperature().ToString();
    }

    public void Display()
    {
        Console.WriteLine($"Windows|Temperature: {temperature} ºC");
    }
}
