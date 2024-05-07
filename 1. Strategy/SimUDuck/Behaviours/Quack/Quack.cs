namespace SimUDuck.Behaviours.Quack;

internal class Quack : IQuackBehaviour
{
    void IQuackBehaviour.Quack()
    {
        Console.WriteLine("Quack");
    }
}
