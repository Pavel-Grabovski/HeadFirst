namespace HeadFirst.Commands;

public class StereoOffCommand : ICommand
{
    private readonly Stereo stereo;

    public StereoOffCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.Off();
    }

    public void Undo()
    {
        stereo.On();
        stereo.SetCD();
        stereo.SetVolume(11);
    }
}
