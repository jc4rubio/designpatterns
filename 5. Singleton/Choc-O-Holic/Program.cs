using Choc_O_Holic;

Console.WriteLine("Singleton pattern");
Console.WriteLine("=================");

ChocolateBoiler boilerA = ChocolateBoiler.GetInstance();
ChocolateBoiler boilerB = ChocolateBoiler.GetInstance();

Console.WriteLine("Boilers are the same: " + (boilerA == boilerB));

boilerA.Fill();
Console.WriteLine("Fill");
Console.WriteLine("Empty: " + boilerA.IsEmpty);
Console.WriteLine("Boiled: " + boilerA.IsBoiled);

boilerA.Boil();
Console.WriteLine("Boil");
Console.WriteLine("Empty: " + boilerA.IsEmpty);
Console.WriteLine("Boiled: " + boilerA.IsBoiled);

boilerA.Drain();
Console.WriteLine("Drain");
Console.WriteLine("Empty: " + boilerA.IsEmpty);
Console.WriteLine("Boiled: " + boilerA.IsBoiled);

Console.WriteLine("");
Console.WriteLine("Singleton with eager initialization");
Console.WriteLine("===================================");

#region Singletons comparer

const int NInstances = 4;

SingletonWithEagerInitialization[] singletonsWithEagerInitialization = new SingletonWithEagerInitialization[NInstances];
Action[] getSingletonWithEagerInitialization = new Action[NInstances];

for (int i = 0; i < NInstances; i++)
{
    int index = i;
    getSingletonWithEagerInitialization[i] = () => singletonsWithEagerInitialization[index] = SingletonWithEagerInitialization.GetInstance();
}

Parallel.Invoke(getSingletonWithEagerInitialization);
Console.WriteLine("All singletons with eager initialization are the same (must be true): " + Array.TrueForAll(singletonsWithEagerInitialization, x => x == singletonsWithEagerInitialization[0]));

Console.WriteLine("");
Console.WriteLine("Singleton with locker for thread safe");
Console.WriteLine("=====================================");

SingletonWithLocker[] singletonsWithLocker = new SingletonWithLocker[NInstances];
Action[] getSingletonsWithLocker = new Action[NInstances];

for (int i = 0; i < NInstances; i++)
{
    int index = i;
    getSingletonsWithLocker[i] = () => singletonsWithLocker[index] = SingletonWithLocker.GetInstance();
}

Parallel.Invoke(getSingletonsWithLocker);
Console.WriteLine("All singletons with locker are the same (must be true): " + Array.TrueForAll(singletonsWithLocker, x => x == singletonsWithLocker[0]));

Console.WriteLine("");
Console.WriteLine("Singleton without locker for thread safe");
Console.WriteLine("========================================");

const int NoLockerInstances = 100;

ChocolateBoiler[] singletonsWithoutLocker = new ChocolateBoiler[NoLockerInstances];
Action[] getSingletonsWithoutLocker = new Action[NoLockerInstances];

for (int i = 0; i < NoLockerInstances; i++)
{
    int index = i;
    getSingletonsWithoutLocker[i] = () => singletonsWithoutLocker[index] = ChocolateBoiler.GetInstance();
}

Parallel.Invoke(getSingletonsWithoutLocker);
Console.WriteLine("All singletons without locker are the same (maybe not): " + Array.TrueForAll(singletonsWithoutLocker, x => x == singletonsWithoutLocker[0]));
   
#endregion
