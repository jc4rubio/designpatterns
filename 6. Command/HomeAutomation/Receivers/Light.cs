namespace HomeAutomation.Receivers;

using System;

internal class Light(string location)
{
    public string Location { get; } = location;

    public void On()
    {
        Console.WriteLine("Turning light on at " + this.Location);
    }

    public void Off()
    {
        Console.WriteLine("Turning light off at " + this.Location);
    }
}
