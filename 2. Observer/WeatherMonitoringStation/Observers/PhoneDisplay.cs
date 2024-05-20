namespace WeatherMonitoringStation;

internal class PhoneDisplay(WeatherStation station) : IObserver, IDisplay
{
    private readonly WeatherStation station = station;

    private string temperature = string.Empty;
    private string humidity = string.Empty;
    private string presure = string.Empty;

    public void Update()
    {
        this.temperature = this.station.GetTemperature().ToString();
        this.humidity = this.station.GetHumidity().ToString();
        this.presure = this.station.GetPresure().ToString();
    }

    public void Display()
    {
        string display = $@"
--------------------------------
Phone
--------------------------------
  Temperature: {temperature} ºC
  Humidity:    {humidity} %
  Presure:     {presure} hPa
--------------------------------
        ";
             
        Console.WriteLine(display);
    }
}
