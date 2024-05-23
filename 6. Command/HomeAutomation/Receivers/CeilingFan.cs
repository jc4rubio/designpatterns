namespace HomeAutomation.Receivers;

internal class CeilingFan(string location)
{
    private CeilingFanSpeed speed;

    public string Location { get; } = location;
    public CeilingFanSpeed GetSpeed() => this.speed;

    public void Off()
    {
        Console.WriteLine($"Ceiling fan Off at {this.Location}");
        this.speed = CeilingFanSpeed.Off;
    }

    public void Low()
    {
        Console.WriteLine($"Ceiling fan Low at {this.Location}");
        this.speed = CeilingFanSpeed.Low;
    }

    public void Medium()
    {
        Console.WriteLine($"Ceiling fan Medium at {this.Location}");
        this.speed = CeilingFanSpeed.Medium;
    }

    public void High()
    {
        Console.WriteLine($"Ceiling fan High at {this.Location}");
        this.speed = CeilingFanSpeed.High;
    }

    public void SetSpeed(CeilingFanSpeed sped)
    {
        this.speed = sped;
    }
}

internal enum CeilingFanSpeed
{
    Off = 0,
    Low = 1,
    Medium = 2,
    High = 3,
}
