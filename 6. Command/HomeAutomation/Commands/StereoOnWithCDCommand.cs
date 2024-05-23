namespace HomeAutomation.Commands;

using HomeAutomation.Receivers;

internal class StereoOnWithCDCommand(Stereo stereo) : ICommand
{
    private readonly Stereo stereo = stereo;

    private const int DefaultVolume = 11;

    public void Execute()
    {
        this.stereo.On();
        this.stereo.SetCd();
        this.stereo.SetVolume(DefaultVolume);
    }

    public void Undo()
    {
        this.stereo.SetVolume(0);
        this.stereo.Off();
    }
}
