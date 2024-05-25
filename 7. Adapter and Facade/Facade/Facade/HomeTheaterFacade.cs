namespace Facade;

using Facade.HomeTheater;

internal class HomeTheaterFacade(Amplifier amplifier, Tuner tuner, StreamingPlayer player, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper) : IHomeTheaterFacade
{
    private readonly Amplifier amplifier = amplifier;
    private readonly Tuner tuner = tuner;
    private readonly StreamingPlayer player = player;
    private readonly Projector projector = projector;
    private readonly TheaterLights lights = lights;
    private readonly Screen screen = screen;
    private readonly PopcornPopper popper = popper;

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        this.popper.On();
        this.popper.Pop();
        this.lights.Dim(10);
        this.screen.Down();
        this.projector.On();
        this.projector.SetInput(player);
        this.projector.WideScreenMode();
        this.amplifier.On();
        this.amplifier.SetStreamingPlayer(player);
        this.amplifier.SetSurroundSound();
        this.amplifier.SetVolume(5);
        this.tuner.Off();
        this.player.On();
        this.player.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        this.popper.Off();
        this.lights.Off();
        this.screen.Up();
        this.projector.Off();
        this.amplifier.Off();
        this.player.Stop();
        this.player.Off();
    }
}