namespace HomeAutomation.Invokers;

using System.Text;
using HomeAutomation.Commands;

internal class RemoteControl
{
    private readonly IList<ICommand> onCommands;
    private readonly IList<ICommand> offCommands;

    private const int TotalButtons = 7;

    public RemoteControl()
    {
        this.onCommands = new ICommand[7];
        this.offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();

        for (int i = 0; i < TotalButtons; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        this.onCommands[slot] = onCommand;
        this.offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        this.onCommands[slot].Execute();
    }

    public void OffButtonWasPushed(int slot)
    {
        this.offCommands[slot].Execute();
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine("\n-----------Remote Control -------");
        for (int i = 0; i < onCommands.Count; i++)
        {
            sb.AppendLine("[slot] " + i + "] " + this.onCommands[i].GetType().Name + "    " + this.offCommands[i].GetType().Name);
        }

        return sb.ToString();
    }
}
