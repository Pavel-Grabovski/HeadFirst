
namespace HeadFirst.Facade.Models;

public class PopcornPopper
{
    internal void Off()
    {
        Console.WriteLine("Popcorn Popper off");
    }

    internal void On()
    {
        Console.WriteLine("Popcorn Popper on");
    }

    internal void Pop()
    {
        Console.WriteLine("Popcorn Popper pop");
    }
}