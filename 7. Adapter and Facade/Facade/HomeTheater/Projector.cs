namespace Facade.HomeTheater;

internal class Projector
{
    public StreamingPlayer? Player { get; set; }
    
    public void SetInput(StreamingPlayer player) => this.Player = player;
    public void On() => Console.WriteLine("Projector On");
    public void Off() => Console.WriteLine("Projector Off");
    public void TvMode() => Console.WriteLine("Projector: Tv Mode");
    public void WideScreenMode() => Console.WriteLine("Projector: Wide Screen Mode");
    public override string ToString() => "Projector";
}
