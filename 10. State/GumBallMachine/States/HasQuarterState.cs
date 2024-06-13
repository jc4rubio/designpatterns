namespace GlobalMachineState;

internal class HasQuarterState(GumballMachine machine) : IState
{
    private readonly GumballMachine gumballMachine = machine;
    private readonly Random randomWinner = new();

    public void InsertQuarter() => Console.WriteLine("You can't insert another quarter");

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        this.gumballMachine.SetState(this.gumballMachine.NoQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("Your turned...");
        int winner = randomWinner.Next(10);
        if (winner == 0 && gumballMachine.Count > 1)
        {
            this.gumballMachine.SetState(this.gumballMachine.WinnerState);
        }
        else
        {
            this.gumballMachine.SetState(this.gumballMachine.SoldState);
        }
    }

    public void Dispense()
    {
        this.gumballMachine.ReleaseBall();

        if (this.gumballMachine.Count > 0)
        {
            this.gumballMachine.SetState(this.gumballMachine.NoQuarterState);
        }
        else
        {
            Console.WriteLine("Oops, out of gumbballs!");
            this.gumballMachine.SetState(this.gumballMachine.SoldOutState);
        }
    }

    public void Refill() => Console.WriteLine("Refilling the machine");
}