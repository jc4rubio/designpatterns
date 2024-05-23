namespace HomeAutomation.Receivers;

using System;

internal class Stereo(string location)
{
    public string Location { get; } = location;

    private int volume = 0;

    public void On()
    {
        Console.WriteLine($"Turning On stereo at {this.Location}. Volume: {this.volume}");
    }

    public void Off()
    {
        Console.WriteLine($"Turning off stereo at {this.Location}");
    }

    public void SetCd()
    {
        Console.WriteLine($"Setting Cd in stereo at {this.Location}");
    }

    public void SetDvd()
    {
        Console.WriteLine($"Setting Dvd in stereo at {this.Location}");
    }
    
    public void SetRadio()
    {
        Console.WriteLine($"Setting radio in stereo at {this.Location}");
    }

    public void SetVolume(int volume)
    {
        this.volume = volume;
        Console.WriteLine($"Setting volume to {volume} in stereo at {this.Location}");
    }
}
