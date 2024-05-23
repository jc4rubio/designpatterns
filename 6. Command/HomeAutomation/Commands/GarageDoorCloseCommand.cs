namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class GarageDoorCloseCommand(GarageDoor garageDoor) : ICommand
{
    private readonly GarageDoor garageDoor = garageDoor;

    public void Execute()
    {
        this.garageDoor.Close();
    }

    public void Undo()
    {
        this.garageDoor.Open();
    }
}
