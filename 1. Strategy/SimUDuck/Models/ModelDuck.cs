namespace SimUDuck;

using System;
using SimUDuck.Behaviours;
using SimUDuck.Behaviours.Quack;

internal class ModelDuck : Duck
{
    public ModelDuck()
    {
        this.FlyBehaviour = new FlyNoWay();
        this.QuackBehaviour = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("'I'm a model duck");
    }
}
