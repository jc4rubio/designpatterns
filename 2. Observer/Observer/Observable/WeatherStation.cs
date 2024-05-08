namespace WeatherMonitoringStation;

internal class WeatherStation : IObservable
{
    private List<IObserver> Observers { get; set; } = [];

    public void Add(IObserver observer)
    {
        this.Observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        this.Observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in this.Observers)
        {
            observer.Update();
        }
    }

    public float GetTemperature()
    {
        return new Random(DateTime.Now.Minute).Next(100, 350) / 10f;
    }
}
