namespace SimUDuck;

using System;
using SimUDuck.Behaviours;
using SimUDuck.Behaviours.Quack;

internal class MallarDuck : Duck
{
    public MallarDuck()
    {
        this.FlyBehaviour = new FlyWithWings();
        this.QuackBehaviour = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("'I'm a real Mallard duck");
    }
}
