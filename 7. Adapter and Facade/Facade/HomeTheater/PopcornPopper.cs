namespace Facade.HomeTheater;

internal class PopcornPopper
{
    public void On() => Console.WriteLine("Pop On");
    public void Off() => Console.WriteLine("Pop Off");
    public void Pop() => Console.WriteLine("Pop!");
    public override string ToString() => "Popcorn Popper";
}
