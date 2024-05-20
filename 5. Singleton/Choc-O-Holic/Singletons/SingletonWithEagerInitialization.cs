namespace Choc_O_Holic;

internal class SingletonWithEagerInitialization
{
    private SingletonWithEagerInitialization() { }

    private static readonly SingletonWithEagerInitialization uniqueInstance = new();

    public static SingletonWithEagerInitialization GetInstance() => uniqueInstance;
}