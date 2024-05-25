namespace Facade.HomeTheater;

using System;
using System.Threading.Channels;

internal class StreamingPlayer
{
    public Amplifier Amplifier { get; set; } = default!;
    
    public void On() => Console.WriteLine("Streaming Player: On");
    public void Off() => Console.WriteLine("Streaming Player: Off");
    public void Pause() => Console.WriteLine("Streaming Player: Pause");
    public void Stop() => Console.WriteLine("Streaming Player: Stop");
    public void Play(string content) => Console.WriteLine("Streaming Player: Playing " + content);
    public void SetSurroundAudio(bool enabled) => this.Amplifier.SetSurroundSound(enabled);
    public void SetTwoChannelAudio(bool enabled) => Console.WriteLine("Streaming Player: Two channels enabled: " + enabled);
    public override string ToString() => "Streaming Player";
}
