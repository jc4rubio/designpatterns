namespace SimUDuck.Behaviours;

using System;

internal class FlyNoWay : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}
