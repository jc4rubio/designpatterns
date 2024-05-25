namespace Adapter;

using System;

internal class DuckAdapter(IDuck duck) : ITurkey
{
    private readonly IDuck duck = duck;

    private readonly Random rand = new();

    public void Gobble()
    {
        this.duck.Quack();
    }

    public void Fly()
    {
        if (this.rand.Next(0, 5) == 0)
        {
            this.duck.Fly();
        }
    }
}
