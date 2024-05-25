namespace Adapter;

using System;

internal class MallarDuck : IDuck
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flaying");
    }
}
