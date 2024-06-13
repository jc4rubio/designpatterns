namespace GlobalMachineState;

internal class SoldOutState(GumballMachine machine) : IState
{
    private readonly GumballMachine machine = machine;

    public void InsertQuarter() => Console.WriteLine("You can't insert a quarter, the machine is sold out");

    public void EjectQuarter() => Console.WriteLine("You can't eject, you haven't inserted a quarter yet");

    public void TurnCrank() => Console.WriteLine("You turned but there are no gumballs");

    public void Dispense() => Console.WriteLine("No gumball dispensed");

    public void Refill()
    {
        Console.WriteLine("Refilling the machine");
        this.machine.SetState(this.machine.NoQuarterState);
    }
}
