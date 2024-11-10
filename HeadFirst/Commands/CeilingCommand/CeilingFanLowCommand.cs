using HeadFirst.Commands.Models;

namespace HeadFirst.Commands.CeilingCommand;

public class CeilingFanLowCommand : CeilingFanSpeedCommand
{
    public CeilingFanLowCommand(CeilingFan ceilingFan)
        : base(ceilingFan) { }

    public override void Execute()
    {
        _prevSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.SetSpeed(SpeedEnum.Low);
    }
}

