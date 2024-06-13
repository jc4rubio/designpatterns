namespace GlobalMachineState;

internal class SoldState(GumballMachine machine) : IState
{
    private readonly GumballMachine gumballMachine = machine;

    public void InsertQuarter() => Console.WriteLine("Please wait, we're already giving you a gumball");

    public void EjectQuarter() => Console.WriteLine("Sorry, you already turned the crank");

    public void TurnCrank() => Console.WriteLine("Turning twice  doesn't get you another gumball!");

    public void Dispense()
    {
        this.gumballMachine.ReleaseBall();

        if (this.gumballMachine.Count > 0)
        {
            this.gumballMachine.SetState(this.gumballMachine.NoQuarterState);
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            this.gumballMachine.SetState(this.gumballMachine.SoldOutState);
        }
    }

    public void Refill() => Console.WriteLine("Refilling the machine");
}
