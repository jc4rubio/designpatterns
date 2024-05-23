namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class LightOnCommand(Light light) : ICommand
{
    private readonly Light light = light;

    public void Execute()
    {
        this.light.On();
    }

    public void Undo()
    {
        this.light.Off();
    }
}
