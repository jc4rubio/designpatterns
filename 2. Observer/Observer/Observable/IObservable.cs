namespace WeatherMonitoringStation;

internal interface IObservable
{
    void Add(IObserver observer);

    void Remove(IObserver observer);

    void Notify();
}
