﻿namespace HeadFirst.Commands;

public class StereoOnWithCDCommand : ICommand
{
    private readonly Stereo stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.On();
        stereo.SetCD();
        stereo.SetVolume(11);
    }

    public void Undo()
    {
        stereo.Off();
    }
}
