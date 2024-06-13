namespace GlobalMachineState;

internal class NoQuarterState(GumballMachine machine) : IState
{
    private readonly GumballMachine gumballMachine = machine;

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        this.gumballMachine.SetState(this.gumballMachine.HasQuarterState);
    }

    public void EjectQuarter() => Console.WriteLine("You haven't inserted a quarter");

    public void TurnCrank() => Console.WriteLine("You tourned, but there's no quarter");

    public void Dispense() => Console.WriteLine("You need to pay first");

    public void Refill() => Console.WriteLine("Refilling the machine");
}
