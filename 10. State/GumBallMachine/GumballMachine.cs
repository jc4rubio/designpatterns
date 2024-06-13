namespace GlobalMachineState;

using System.Text;

internal class GumballMachine
{
    public IState SoldState { get; init; }
    public IState NoQuarterState { get; init; }
    public IState HasQuarterState { get; init; }
    public IState WinnerState { get; init; }
    public IState SoldOutState { get; init; }

    private IState state;

    public int Count { get; private set; } = 0;

    public GumballMachine(int numberGumballs)
    {
        this.SoldState = new SoldState(this);
        this.NoQuarterState = new NoQuarterState(this);
        this.HasQuarterState = new HasQuarterState(this);
        this.SoldOutState = new SoldOutState(this);
        this.WinnerState = new WinnerState(this);

        this.Count = numberGumballs;
        this.state = numberGumballs > 0 ? this.NoQuarterState : this.SoldOutState;
    }

    public void InsertQuarter()
    {
        this.state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        this.state.EjectQuarter();
    }

    public void TurnCrank()
    {
        this.state.TurnCrank();
        this.state.Dispense();
    }

    public void SetState(IState state) => this.state = state;

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        this.Count--;
    }

    public void Refill(int balls)
    {
        this.Count += balls;
        Console.WriteLine("The gumball machine was just refilled; its new count is " + this.Count);
        this.state.Refill();
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine("Mighty Gumball, Inc");
        sb.AppendLine("net-enabled Standing Gumball Model #2024");
        sb.AppendLine($"Inventory: {this.Count} gumballs");
        sb.AppendLine($"Machine status: {this.state.GetType().Name}");

        return sb.ToString();
    }
}