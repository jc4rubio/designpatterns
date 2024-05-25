namespace Adapter;

internal class TurkeyAdapter(ITurkey turkey) : IDuck
{
    private readonly ITurkey turkey = turkey;

    public void Quack()
    {
        this.turkey.Gobble();
    }

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            this.turkey.Fly();
        }
    }
}
