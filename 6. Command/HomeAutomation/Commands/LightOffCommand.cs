namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class LightOffCommand(Light light) : ICommand
{
    private readonly Light light = light;

    public void Execute()
    {
        this.light.Off();
    }

    public void Undo()
    {
        this.light.On();
    }
}
