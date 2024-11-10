using HeadFirst.Commands.CeilingCommand;
using HeadFirst.Commands.Controls;
using HeadFirst.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Commands;

public class RemoteLoader
{
    public static void Start()
    {
        RemoteControl remoteControl = new RemoteControl();

        CeilingFan ceilingFan = new CeilingFan("Living Room");

        CeilingFanMediumCommand ceilingFanMedium = new (ceilingFan);

        CeilingFanHighCommand ceilingFanHigh = new (ceilingFan);

        CeilingFanOffCommand ceilingFanOff = new (ceilingFan);

        remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
        remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

        remoteControl.OnButtonPushed(0);
        remoteControl.OffButtonPushed(0);

        Console.WriteLine(remoteControl);

        remoteControl.UndoButtonPushed();

        remoteControl.OnButtonPushed(1);
        Console.WriteLine(remoteControl);

        remoteControl.UndoButtonPushed();
        Console.WriteLine(remoteControl);

    }
}
