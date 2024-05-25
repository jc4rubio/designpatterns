namespace Facade.HomeTheater;

internal class Tuner
{
    public Amplifier Amplifier { get; set; } = default!;
    public void On() => Console.WriteLine("Tuner On");
    public void Off() => Console.WriteLine("Tuner Off");
    public void SetAm() => Console.WriteLine("Tuner mode: AM");
    public void SetFm() => Console.WriteLine("Tuner mode: FM");
    public void SetFrequency(float frequency) => Console.WriteLine("Tuner frequency: " + frequency);
    public override string ToString() => "Tuner";
}
