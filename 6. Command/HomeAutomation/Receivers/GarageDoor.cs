namespace HomeAutomation.Receivers;

using System;

internal class GarageDoor(string location)
{
    public string Location { get; } = location;

    public void Open()
    {
        Console.WriteLine("Opening door at " + this.Location);
    }

    public void Close()
    {
        Console.WriteLine("Closing door at " + this.Location);
    }
}
