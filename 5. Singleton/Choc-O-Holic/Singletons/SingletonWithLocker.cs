namespace Choc_O_Holic;

internal class SingletonWithLocker
{
    private SingletonWithLocker()
    {

    }

    private static SingletonWithLocker? uniqueInstance;

    private static readonly object _locker = new();

    public static SingletonWithLocker GetInstance()
    {
        lock (_locker)
        {
            uniqueInstance ??= new SingletonWithLocker();
        }

        return uniqueInstance;
    }
}
