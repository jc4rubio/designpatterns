namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class CeilingFanOffCommand(CeilingFan ceilingFan) : ICommand
{
    private readonly CeilingFan ceilingFan = ceilingFan;

    private CeilingFanSpeed previousSpeed = ceilingFan.GetSpeed();

    public void Execute()
    {
        this.previousSpeed = ceilingFan.GetSpeed();
        this.ceilingFan.Off();
    }

    public void Undo()
    {
        this.ceilingFan.SetSpeed(this.previousSpeed);
    }
}
