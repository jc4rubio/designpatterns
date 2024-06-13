namespace GlobalMachineState;

internal interface IState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
    void Refill();
}
