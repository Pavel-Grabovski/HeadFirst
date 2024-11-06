namespace HeadFirst.Commands.Models;

public class Light
{
    private readonly string _name;

    public Light(string name)
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine("Light On");
    }

    public void Off()
    {
        Console.WriteLine("Light off");
    }
}
