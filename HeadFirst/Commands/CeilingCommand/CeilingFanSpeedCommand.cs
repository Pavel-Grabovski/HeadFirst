using HeadFirst.Commands.Models;

namespace HeadFirst.Commands.CeilingCommand;

public abstract class CeilingFanSpeedCommand : ICommand
{
    private protected readonly CeilingFan _ceilingFan;

    private protected SpeedEnum _prevSpeed;

    protected CeilingFanSpeedCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public abstract void Execute();

    public void Undo()
    {
        switch (_prevSpeed)
        {
            case SpeedEnum.High:
                _ceilingFan.SetSpeed(SpeedEnum.High);
                break;
            case SpeedEnum.Medium:
                _ceilingFan.SetSpeed(SpeedEnum.Medium);
                break;
            case SpeedEnum.Low:
                _ceilingFan.SetSpeed(SpeedEnum.Low);
                break;
            case SpeedEnum.Off:
                _ceilingFan.SetSpeed(SpeedEnum.Off);
                break;
        }
    }
}

