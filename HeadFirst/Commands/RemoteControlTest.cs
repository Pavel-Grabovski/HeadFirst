using HeadFirst.Commands.Controls;
using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class RemoteControlTest
{
    public static void Start()
    {
        RemoteControl remoteControl = new RemoteControl();

        Light livingRoomLight = new Light("Living Room");
        Light kitchenLight = new Light("Kitchen");
        CeilingFan ceilingFan = new CeilingFan("Living Room");
        GarageDoor garageDoor = new GarageDoor();
        Stereo stereo = new Stereo("Living Room");

        LightOnCommand livingRoomLightOn = new (livingRoomLight);
        LightOffCommand livingRoomLightOff = new (livingRoomLight);
        LightOnCommand kitchenLightOn = new (kitchenLight);
        LightOffCommand kitchenLightOff =new (kitchenLight);

        CeilingFanOnCommand ceilingFanOn = new (ceilingFan);
        CeilingFanOffCommand ceilingFanOff = new (ceilingFan);

        GarageDoorUpCommand garageDoorUp = new (garageDoor);
        GarageDoorDownCommand garageDoorDown =new (garageDoor);

        StereoOnWithCDCommand stereoOnWithCD = new (stereo);
        StereoOffCommand stereoOff = new (stereo);

        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
        remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

        remoteControl.OnButtonPushed(0);
        remoteControl.OffButtonPushed(0);
        remoteControl.OnButtonPushed(1);
        remoteControl.OffButtonPushed(1);
        remoteControl.OnButtonPushed(2);
        remoteControl.OffButtonPushed(2);
        remoteControl.OnButtonPushed(3);
        remoteControl.OffButtonPushed(3);

    }
}
