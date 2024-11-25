

namespace HeadFirst.Facade.Models;

public class Projector
{
    internal void Off()
    {
        Console.WriteLine("Projector off");
    }

    internal void On()
    {
        Console.WriteLine("Projector on");
    }

    internal void WideScreenMode()
    {
        Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio)");
    }
}
