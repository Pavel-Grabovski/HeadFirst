using HeadFirst.Commands.Models;

namespace HeadFirst.Commands.CeilingCommand;

public class CeilingFanOffCommand : CeilingFanSpeedCommand
{
    public CeilingFanOffCommand(CeilingFan ceilingFan) 
        : base(ceilingFan)
    {
    }

    public override void Execute()
    {
        _prevSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.SetSpeed(SpeedEnum.Off);
    }
}