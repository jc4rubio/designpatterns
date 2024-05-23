namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class CeilingFanMediumCommand(CeilingFan ceilingFan) : ICommand
{
    private readonly CeilingFan ceilingFan = ceilingFan;

    private CeilingFanSpeed previousSpeed = ceilingFan.GetSpeed();

    public void Execute()
    {
        this.previousSpeed = ceilingFan.GetSpeed();
        this.ceilingFan.Medium();
    }

    public void Undo()
    {
        this.ceilingFan.SetSpeed(this.previousSpeed);
    }
}
