using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class HottubOnCommand : ICommand
{
    private readonly Hottub _hottub;

    public HottubOnCommand(Hottub hottub)
    {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.On();
    }

    public void Undo()
    {
        _hottub.Off();
    }
}