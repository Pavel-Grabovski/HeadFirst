using HeadFirst.Facade.Models;

namespace HeadFirst.Facade;

public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier;
    private readonly Tuner _tuner;
    private readonly StreamingPlayer _player;
    private readonly Projector _projector;
    private readonly TheaterLights _lights;
    private readonly Screen _screen;
    private readonly PopcornPopper _popper;

    public HomeTheaterFacade(
        Amplifier amplifier,
        Tuner tuner,
        StreamingPlayer player,
        Projector projector,
        TheaterLights lights,
        Screen screen,
        PopcornPopper popper)
    {
        _amplifier = amplifier;
        _tuner = tuner;
        _player = player;
        _projector = projector;
        _lights = lights;
        _screen = screen;
        _popper = popper;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine($"Get ready to watch a movie {movie}");

        _popper.On();
        _popper.Pop();

        _lights.Dim(10);

        _screen.Down();

        _projector.On();
        _projector.WideScreenMode();

        _amplifier.On();
        _amplifier.SetStreamingPlayer(_player);
        _amplifier.SetSurroundSound();
        _amplifier.SetVolume(5);

        _player.Off();
        _player.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine($"Shutting movie theater down");

        _popper.Off();

        _lights.On();

        _screen.Up();

        _projector.Off();

        _amplifier.Off();

        _player.Stop();
        _player.Off();
    }
}
