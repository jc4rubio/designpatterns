using Adapter;

Console.WriteLine("Adapter pattern");
Console.WriteLine("---------------");

TestTurkeyAdapter();

static void TestTurkeyAdapter()
{
    Console.WriteLine("\n" + nameof(TestTurkeyAdapter) + "\n");

    MallarDuck duck = new();
    WildTurkey turkey = new();
    IDuck turkeyAdapter = new TurkeyAdapter(turkey);

    Console.WriteLine("The Turkey says...");
    TestTurkey(turkey);

    Console.WriteLine("\nThe Duck says...");
    TestDuck(duck);

    Console.WriteLine("\nThe TurkeyAdapter says...");
    TestDuck(turkeyAdapter);    
}

TestDuckAdapter();

static void TestDuckAdapter()
{
    Console.WriteLine("\n" + nameof(TestDuckAdapter) + "\n");

    WildTurkey turkey = new();
    MallarDuck duck = new();
    ITurkey duckAdapter = new DuckAdapter(duck);

    Console.WriteLine("The Duck says...");
    TestDuck(duck);

    Console.WriteLine("\nThe Turkey says...");
    TestTurkey(turkey);

    Console.WriteLine("\nThe DuckAdapter says...");
    TestTurkey(duckAdapter);   
}

static void TestTurkey(ITurkey turkey)
{
    turkey.Gobble();
    turkey.Fly();
}

static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}
