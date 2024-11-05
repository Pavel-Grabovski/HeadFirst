using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Commands.Controls;

public class RemoteControl
{
    private ICommand[] onCommands;
    private ICommand[] OffCommands;

    public RemoteControl()
    {
        onCommands = new ICommand[7];
        OffCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();

        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            OffCommands[i] = noCommand;
        }
    }

    private class NoCommand : ICommand
    {
        public void Execute() { }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        OffCommands[slot] = offCommand;
    }

    public void OnButtonPushed(int slot)
    {
        onCommands[slot].Execute();
    }

    public void OffButtonPushed(int slot)
    {
        onCommands[slot].Execute();
    }
}
