using System.Text;

namespace HeadFirst.Commands.Controls;

public class RemoteControl
{
    private ICommand[] onCommands;
    private ICommand[] offCommands;
    private ICommand undoCommand;
    public RemoteControl()
    {
        onCommands = new ICommand[7];
        offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();

        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
        undoCommand = noCommand;
    }

    private class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonPushed(int slot)
    {
        onCommands[slot].Execute();
        undoCommand = onCommands[slot];
    }

    public void OffButtonPushed(int slot)
    {
        offCommands[slot].Execute();
        undoCommand = offCommands[slot];
    }

    public void UndoButtonPushed()
    {
        undoCommand.Undo();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("\n ------- Remote Contrlol ------- \n");

        sb.Append($"Undo: {undoCommand.ToString()}\n");

        for (int i = 0; i < onCommands.Length; i++)
        {
            sb.Append($"Slot: {i} {onCommands[i].ToString()} -- {offCommands[i].ToString()} \n");
        }

        return sb.ToString();
    }



}
