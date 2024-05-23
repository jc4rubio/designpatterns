namespace HomeAutomation.Commands;

internal class MacroCommand(IList<ICommand> commands) : ICommand
{
    public IList<ICommand> Commands { get; } = commands;

    public void Execute()
    {
        foreach (ICommand command in this.Commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        for (int i = Commands.Count - 1; i >= 0; i--)
        {
            this.Commands[i].Undo();
        }
    }
}
