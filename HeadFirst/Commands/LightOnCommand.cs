using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        this._light = light;
    }

    public void Execute()
    {
       _light.On();
    }

    public void Undo()
    {
        _light.Off();
    }
}
