namespace GlobalMachineState;

internal class WinnerState(GumballMachine gumballMachine) : IState
{
    private readonly GumballMachine gumballMachine = gumballMachine;

    public void InsertQuarter() => Console.WriteLine("Please wait, we're already giving you a gumball");

    public void EjectQuarter() => Console.WriteLine("Sorry, you already turned the crank");

    public void TurnCrank() => Console.WriteLine("Turning twice  doesn't get you another gumball!");

    public void Dispense()
    {
        this.gumballMachine.ReleaseBall();

        if (gumballMachine.Count == 0)
        {
            this.gumballMachine.SetState(this.gumballMachine.SoldOutState);
        }
        else
        {
            this.gumballMachine.ReleaseBall();
            Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");

            if (this.gumballMachine.Count > 0)
            {
                this.gumballMachine.SetState(this.gumballMachine.NoQuarterState);
            }
            else
            {
                this.gumballMachine.SetState(this.gumballMachine.SoldOutState);
            }
        }
    }

    public void Refill() => Console.WriteLine("Refilling the machine");
}
