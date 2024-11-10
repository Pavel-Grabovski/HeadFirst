using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class HottubOffCommand : ICommand
{
    private readonly Hottub _hottub;

    public HottubOffCommand(Hottub hottub)
    {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.Off();
    }

    public void Undo()
    {
        _hottub.On();
    }
}