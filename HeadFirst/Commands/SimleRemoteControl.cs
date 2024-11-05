namespace HeadFirst.Commands;

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

public class RemoteControlTest
{
    public static void Start()
    {
        SimleRemoteControl remote = new SimleRemoteControl();

        Light light = new ();

        LightOnCommand lightOn = new(light);

        remote.SetCommand(lightOn);
        remote.ButtonWasPressed();
    }
}
