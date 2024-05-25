namespace Facade.HomeTheater;

internal class TheaterLights
{
    public void On() => Console.WriteLine("Lights On");
    public void Off() => Console.WriteLine("Lights Off");
    public void Dim(int value) => Console.WriteLine("Lights: Dim to " + value);
    public override string ToString() => "Teather lights";
}