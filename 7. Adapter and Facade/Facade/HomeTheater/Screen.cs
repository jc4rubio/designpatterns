namespace Facade.HomeTheater;

internal class Screen
{
    public void Up() => Console.WriteLine("Screen Up");
    public void Down() => Console.WriteLine("Screen Down");
    public override string ToString() => "Screen";
}
