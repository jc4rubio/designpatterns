using Facade;
using Facade.HomeTheater;

Console.WriteLine("Facade pattern");
Console.WriteLine("---------------");

WatchMovieHardWay();

static void WatchMovieHardWay()
{
    Console.WriteLine("\n" + nameof(WatchMovieHardWay) + "\n");

    PopcornPopper popper = new();
    TheaterLights lights = new();
    Screen screen = new();
    StreamingPlayer player = new();
    Projector projector = new();
    Amplifier amplifier = new();

    popper.On();
    popper.Pop();

    lights.Dim(10);

    screen.Down();

    projector.On();
    projector.SetInput(player);
    projector.WideScreenMode();

    amplifier.On();
    amplifier.SetStreamingPlayer(player);
    amplifier.SetSurroundSound();
    amplifier.SetVolume(5);

    player.On();
    player.Play("Dune I");
}

WatchMovieFacade();

static void WatchMovieFacade()
{
    Console.WriteLine("\n" + nameof(WatchMovieFacade) + "\n");

    PopcornPopper popper = new();
    TheaterLights lights = new();
    Screen screen = new();
    StreamingPlayer player = new();
    Projector projector = new();
    Amplifier amplifier = new();
    Tuner tuner = new();

    HomeTheaterFacade homeTheater = new(amplifier, tuner, player, projector, lights, screen, popper);

    homeTheater.WatchMovie("Dune II");

    homeTheater.EndMovie();
}
