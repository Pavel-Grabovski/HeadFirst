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

        //CeilingFan ceilingFan = new CeilingFan("Living Room");

        //CeilingFanMediumCommand ceilingFanMedium = new (ceilingFan);

        //CeilingFanHighCommand ceilingFanHigh = new (ceilingFan);

        //CeilingFanOffCommand ceilingFanOff = new (ceilingFan);

        //remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
        //remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

        //remoteControl.OnButtonPushed(0);
        //remoteControl.OffButtonPushed(0);

        //Console.WriteLine(remoteControl);

        //remoteControl.UndoButtonPushed();

        //remoteControl.OnButtonPushed(1);
        //Console.WriteLine(remoteControl);

        //remoteControl.UndoButtonPushed();
        //Console.WriteLine(remoteControl);


        Light light = new("Living room");
        TV tv = new("Living room");
        Stereo stereo = new("Living room");
        Hottub hottub = new();

        LightOnCommand lightOnCommand = new(light);
        LightOffCommand lightOffCommand = new(light);

        StereoOnWithCDCommand stereoOnWithCDCommand = new(stereo);
        StereoOffCommand stereoOffWithCDCommand = new(stereo);

        TVOnCommand tVOnCommand = new(tv);
        TVOffCommand tVOffCommand = new(tv);

        HottubOnCommand hottubOnCommand = new(hottub);
        HottubOffCommand hottubOffCommand = new(hottub);

        ICommand[] partyOn = { lightOnCommand, stereoOnWithCDCommand, tVOffCommand, hottubOnCommand };
        ICommand[] partyOff = { lightOffCommand, stereoOffWithCDCommand, tVOffCommand, hottubOffCommand };

        MacroCommand partyOnMacro = new(partyOn);
        MacroCommand partyOffMacro = new(partyOff);

        remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);
        Console.WriteLine(remoteControl);

        Console.WriteLine("--- Pushing Macro On ---");
        remoteControl.OnButtonPushed(0);

        Console.WriteLine();

        Console.WriteLine("--- Pushing Macro Off ---");
        remoteControl.OffButtonPushed(0);

    }
}
