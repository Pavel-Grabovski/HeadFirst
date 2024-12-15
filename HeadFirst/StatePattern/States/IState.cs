using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.StatePattern.States;

public interface IState
{
    public void Dispense();
    public void EjectQuarter();
    public void InsertQuarter();
    public void TurnCrank();
    public void Refill();
}
