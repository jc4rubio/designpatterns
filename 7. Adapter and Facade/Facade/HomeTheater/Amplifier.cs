namespace Facade.HomeTheater;

internal class Amplifier
{
    public Tuner Tuner { get; set; } = default!;
    public StreamingPlayer Player { get; set; } = default!;

    public bool StereoSound { get; set; }
    public bool SurroundSound { get; set; }
    public  int Volume { get; set; }

    public void On() => Console.WriteLine("Amplifier On");
    public void Off() => Console.WriteLine("Amplifier Off");
    public void SetStreamingPlayer(StreamingPlayer player) => this.Player = player;
    public void SetStereoSound(bool stereo = true) => this.StereoSound = stereo;
    public void SetSurroundSound(bool surround = true) => this.SurroundSound = surround;
    public void SetTuner(Tuner tuner) => this.Tuner = tuner;
    public void SetVolume(int volume) => this.Volume = volume;
    public override string ToString() => "Amplifier";
}
