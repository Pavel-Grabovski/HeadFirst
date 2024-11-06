using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
       light.On();
    }
}
