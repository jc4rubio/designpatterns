namespace HomeAutomation.Commands;

internal interface ICommand
{
    void Execute();
    void Undo();
}
