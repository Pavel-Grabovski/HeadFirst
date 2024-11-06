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
        GarageDoor garageDoor = new GarageDoor("");
        Stereo stereo = new Stereo("Living Room");

    }
}
