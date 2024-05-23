namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class CeilingFanOnCommand(CeilingFan ceilingFan) : ICommand
{
    private readonly CeilingFan ceilingFan = ceilingFan;

    private CeilingFanSpeed previousSpeed = ceilingFan.GetSpeed();

    public void Execute()
    {
        this.ceilingFan.High();
        this.previousSpeed = ceilingFan.GetSpeed();
    }

    public void Undo()
    {
        this.ceilingFan.SetSpeed(this.previousSpeed);
    }
}
