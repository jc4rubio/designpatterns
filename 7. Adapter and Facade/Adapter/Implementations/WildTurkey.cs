namespace Adapter;

using System;

internal class WildTurkey : ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flaying a short distance");
    }
}
