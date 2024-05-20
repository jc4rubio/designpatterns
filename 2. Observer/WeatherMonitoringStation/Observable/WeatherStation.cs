namespace WeatherMonitoringStation;

internal class WeatherStation : IObservable
{
    private List<IObserver> Observers { get; set; } = [];

    public void Add(IObserver observer) => this.Observers.Add(observer);

    public void Remove(IObserver observer) => this.Observers.Remove(observer);

    public void Notify()
    {
        foreach (IObserver observer in this.Observers)
        {
            observer.Update();
        }
    }

    private Random Random => new(DateTime.Now.Minute);

    public float GetTemperature() => Random.Next(100, 350) / 10f;

    public int GetHumidity() => Random.Next(60, 90);

    public float GetPresure() => 1016 + Random.Next(-3, 3);
}
