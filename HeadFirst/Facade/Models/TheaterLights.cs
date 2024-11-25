
namespace HeadFirst.Facade.Models;

public class TheaterLights
{
    internal void Dim(int v)
    {
        Console.WriteLine($"Theater Ceiling Lights dimming to {v}%");
    }

    internal void On()
    {
        Console.WriteLine($"Theater Ceiling Lights on");
    }
}
