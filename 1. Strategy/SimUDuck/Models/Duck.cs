namespace SimUDuck;

internal abstract class Duck
{
    protected IFlyBehaviour FlyBehaviour { get; set; } = default!;
    protected IQuackBehaviour QuackBehaviour { get; set; } = default!;

    public void Swim()
    {
        Console.WriteLine("All duck float, even decoys!");
    }

    public abstract void Display();

    public void PerformFly()
    {
        this.FlyBehaviour.Fly();
    }

    public void PerformQuack()
    {
        this.QuackBehaviour.Quack();
    }

    public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
    {
        this.FlyBehaviour = flyBehaviour;
    }

    public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
    {
        this.QuackBehaviour = quackBehaviour;
    }
}
