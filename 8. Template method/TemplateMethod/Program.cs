using TemplateMethod;
using TemplateMethod.OthersExamples;

Console.WriteLine("Template method pattern");
Console.WriteLine("-----------------------");

BeverageTestDrive();

static void BeverageTestDrive()
{
    Console.WriteLine("\n" + nameof(BeverageTestDrive) + "\n");

    TeaWithHook teaHook = new();
    CoffeeWithHook coffeHook = new();

    Console.WriteLine("\nMaking tea...");
    teaHook.PrepareRecipe();

    Console.WriteLine("\nMaking coffee...");
    coffeHook.PrepareRecipe();
}

// Array Sort Example. Template method is defined as static in Array Class. Implementation is delegated to the content type: CompareTo method

DuckSortTestDrive();

static void DuckSortTestDrive()
{
    Console.WriteLine("\n" + nameof(DuckSortTestDrive) + "\n");

    Duck[] ducks = [
        new Duck("Daffy", 8),
        new Duck("Dewey", 2),
        new Duck("Howard", 7),
        new Duck("Louie", 2),
        new Duck("Donald", 10),
        new Duck("Huey", 8),
    ];

    Console.WriteLine("\nBefore sorting:");
    Display(ducks);

    Array.Sort(ducks);

    Console.WriteLine("\nAfter sorting:");
    Display(ducks);

    static void Display(Duck[] ducks)
    {
        foreach (Duck duck in ducks)
        {
            Console.WriteLine(duck);
        }
    }
}