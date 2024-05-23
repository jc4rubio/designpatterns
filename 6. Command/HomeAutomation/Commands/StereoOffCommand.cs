namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class StereoOffCommand(Stereo stereo) : ICommand
{
    private readonly Stereo stereo = stereo;

    public void Execute()
    {
        this.stereo.Off();
    }

    public void Undo()
    {
        this.stereo.SetVolume(0);
        this.stereo.Off();
    }
}