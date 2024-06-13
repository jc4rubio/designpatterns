using GlobalMachineState;

Console.WriteLine("State pattern");
Console.WriteLine("-------------");

GumballMachineTestDrive();

static void GumballMachineTestDrive()
{
    GumballMachine gumballMachine = new(5);

    Console.WriteLine(gumballMachine);

    gumballMachine.InsertQuarter();
    gumballMachine.TurnCrank();
    gumballMachine.InsertQuarter();
    gumballMachine.TurnCrank();

    Console.WriteLine(gumballMachine);
}
