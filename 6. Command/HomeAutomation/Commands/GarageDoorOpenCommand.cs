namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class GarageDoorOpenCommand(GarageDoor garageDoor) : ICommand
{
    private readonly GarageDoor garageDoor = garageDoor;

    public void Execute()
    {
        this.garageDoor.Open();
    }

    public void Undo()
    {
        this.garageDoor.Close();
    }
}
