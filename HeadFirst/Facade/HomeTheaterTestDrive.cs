using HeadFirst.Facade.Models;

namespace HeadFirst.Facade;

public class HomeTheaterTestDrive
{
    internal static void Start()
    {
        Amplifier amplifier = new();
        Tuner tuner = new();
        StreamingPlayer player = new();
        Projector projector = new();
        TheaterLights lights = new();
        Screen screen = new();
        PopcornPopper popper = new();

        HomeTheaterFacade homeTheater = new(amplifier, tuner, player, projector, lights, screen, popper);

        homeTheater.WatchMovie("Troy");
        homeTheater.EndMovie();
    }
}
