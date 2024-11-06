namespace HeadFirst.Commands.Controls;

public class SimleRemoteControl
{
    ICommand slot;
    public void SetCommand(ICommand command)
    {
        slot = command;
    }

    public void ButtonWasPressed()
    {
        slot.Execute();
    }
}
