namespace HeadFirst.Commands.Models;

public class CeilingFan
{
    private readonly string _name;

    public CeilingFan(string name)
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine("Ceiling fan on");
    }

    public void Off()
    {
        Console.WriteLine("Ceiling fan off");
    }
}
