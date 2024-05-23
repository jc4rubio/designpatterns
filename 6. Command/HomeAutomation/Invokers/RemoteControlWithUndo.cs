namespace HomeAutomation.Invokers;

using System.Text;
using HomeAutomation.Commands;

internal class RemoteControlWithUndo
{
    private readonly IList<ICommand> onCommands;
    private readonly IList<ICommand> offCommands;
    private ICommand undoCommand;

    private const int TotalButtons = 7;

    public RemoteControlWithUndo()
    {
        this.onCommands = new ICommand[7];
        this.offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();

        for (int i = 0; i < TotalButtons; i++)
        {
            this.onCommands[i] = noCommand;
            this.offCommands[i] = noCommand;
        }
        this.undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        this.onCommands[slot] = onCommand;
        this.offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        this.onCommands[slot].Execute();
        this.undoCommand = this.onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
        this.offCommands[slot].Execute();
        this.undoCommand = this.offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        this.undoCommand.Execute();
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine("\n-----------Remote Control with undo -------");
        for (int i = 0; i < onCommands.Count; i++)
        {
            sb.AppendLine("[slot] " + i + "] " + this.onCommands[i].GetType().Name + "    " + this.offCommands[i].GetType().Name);
        }

        sb.AppendLine("[undo] " + this.undoCommand.GetType().Name);

        return sb.ToString();
    }
}
