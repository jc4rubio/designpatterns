using WeatherMonitoringStation;

Console.WriteLine("Observer pattern on weather monitoring station.");

WeatherStation station = new();

PhoneDisplay phone = new(station);
WindowsDisplay windows = new(station);

station.Add(phone);
station.Add(windows);

station.Notify();

phone.Display();
windows.Display();
