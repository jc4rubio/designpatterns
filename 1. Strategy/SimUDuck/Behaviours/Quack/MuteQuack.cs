namespace SimUDuck.Behaviours.Quack;

using System;

internal class MuteQuack : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}
