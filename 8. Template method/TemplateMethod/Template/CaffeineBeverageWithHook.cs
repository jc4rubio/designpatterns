namespace TemplateMethod;

internal abstract class CaffeineBeverageWithHook
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    protected static void BoilWater() => Console.WriteLine("Boiling water");

    protected static void PourInCup() => Console.WriteLine("Pouring into cup");

    protected abstract void AddCondiments();

    protected abstract void Brew();

    protected virtual bool CustomerWantsCondiments() => true; // Hook
}
