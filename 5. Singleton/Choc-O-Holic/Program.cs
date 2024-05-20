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

SingletonWithEagerInitialization singletonWithEagerInitialization1 = default!;
SingletonWithEagerInitialization singletonWithEagerInitialization2 = default!;
SingletonWithEagerInitialization singletonWithEagerInitialization3 = default!;
SingletonWithEagerInitialization singletonWithEagerInitialization4 = default!;

Action getSingletonEagerInitialization1 = () => singletonWithEagerInitialization1 = SingletonWithEagerInitialization.GetInstance();
Action getSingletonEagerInitialization2 = () => singletonWithEagerInitialization2 = SingletonWithEagerInitialization.GetInstance();
Action getSingletonEagerInitialization3 = () => singletonWithEagerInitialization3 = SingletonWithEagerInitialization.GetInstance();
Action getSingletonEagerInitialization4 = () => singletonWithEagerInitialization4 = SingletonWithEagerInitialization.GetInstance();

Parallel.Invoke(getSingletonEagerInitialization1, getSingletonEagerInitialization2, getSingletonEagerInitialization3, getSingletonEagerInitialization4);

List<SingletonWithEagerInitialization> singletonWithEagerInitializationLockerList = 
    [singletonWithEagerInitialization1, singletonWithEagerInitialization2, singletonWithEagerInitialization3, singletonWithEagerInitialization4];

Console.WriteLine("All singletons with eager initialization are the same (must be true): " + singletonWithEagerInitializationLockerList.TrueForAll(x => x == singletonWithEagerInitializationLockerList[0]));

Console.WriteLine("");
Console.WriteLine("Singleton with locker for thread safe");
Console.WriteLine("=====================================");

SingletonWithLocker singletonWithLocker1 = default!;
SingletonWithLocker singletonWithLocker2 = default!;
SingletonWithLocker singletonWithLocker3 = default!;
SingletonWithLocker singletonWithLocker4 = default!;

Action getSingletonWithLocker1 = () => singletonWithLocker1 = SingletonWithLocker.GetInstance();
Action getSingletonWithLocker2 = () => singletonWithLocker2 = SingletonWithLocker.GetInstance();
Action getSingletonWithLocker3 = () => singletonWithLocker3 = SingletonWithLocker.GetInstance();
Action getSingletonWithLocker4 = () => singletonWithLocker4 = SingletonWithLocker.GetInstance();

Parallel.Invoke(getSingletonWithLocker1, getSingletonWithLocker2, getSingletonWithLocker3, getSingletonWithLocker4);

List<SingletonWithLocker> singletonWithLockerList = 
    [singletonWithLocker1, singletonWithLocker2, singletonWithLocker3, singletonWithLocker4];

Console.WriteLine("All singletons with locker are the same (must be true): " + singletonWithLockerList.TrueForAll(x => x == singletonWithLockerList[0]));

Console.WriteLine("");
Console.WriteLine("Singleton without locker for thread safe");
Console.WriteLine("========================================");

ChocolateBoiler singletonWithoutLocker1 = default!;
ChocolateBoiler singletonWithoutLocker2 = default!;
ChocolateBoiler singletonWithoutLocker3 = default!;
ChocolateBoiler singletonWithoutLocker4 = default!;
ChocolateBoiler singletonWithoutLocker5 = default!;
ChocolateBoiler singletonWithoutLocker6 = default!;
ChocolateBoiler singletonWithoutLocker7 = default!;
ChocolateBoiler singletonWithoutLocker8 = default!;
ChocolateBoiler singletonWithoutLocker9 = default!;

Action getSingletonWithoutLocker1 = () => singletonWithoutLocker1 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker2 = () => singletonWithoutLocker2 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker3 = () => singletonWithoutLocker3 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker4 = () => singletonWithoutLocker4 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker5 = () => singletonWithoutLocker5 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker6 = () => singletonWithoutLocker6 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker7 = () => singletonWithoutLocker7 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker8 = () => singletonWithoutLocker8 = ChocolateBoiler.GetInstance();
Action getSingletonWithoutLocker9 = () => singletonWithoutLocker9 = ChocolateBoiler.GetInstance();

Parallel.Invoke(getSingletonWithoutLocker1, getSingletonWithoutLocker2, getSingletonWithoutLocker3,
                getSingletonWithoutLocker4, getSingletonWithoutLocker5, getSingletonWithoutLocker6,
                getSingletonWithoutLocker7, getSingletonWithoutLocker8, getSingletonWithoutLocker9);

List<ChocolateBoiler> singletonWithoutLockerList =
[
    singletonWithoutLocker1, singletonWithoutLocker2, singletonWithoutLocker3, singletonWithoutLocker4, singletonWithoutLocker5,
    singletonWithoutLocker6, singletonWithoutLocker7, singletonWithoutLocker8, singletonWithoutLocker9
];

Console.WriteLine("All singletons without locker are the same (maybe not): " + singletonWithoutLockerList.TrueForAll(x => x == singletonWithoutLockerList[0]));
