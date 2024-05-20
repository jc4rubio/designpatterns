namespace Choc_O_Holic;

internal class ChocolateBoiler
{
    private ChocolateBoiler()
    {
        this.IsEmpty = true;
        this.IsBoiled = false;
    }

    public bool IsEmpty { get; private set; } = false;
    public bool IsBoiled { get; private set; } = false;

    private static ChocolateBoiler? uniqueInstance;

    public static ChocolateBoiler GetInstance()
    {
        uniqueInstance ??= new ChocolateBoiler();

        return uniqueInstance;
    }

    public void Fill()
    {
        if (this.IsEmpty)
        {
            // fill the boiler with a milk/chocolate fixture
            this.IsEmpty = false;
            this.IsBoiled = false;
        }
    }

    public void Drain()
    {
        if (!this.IsEmpty && this.IsBoiled)
        {
            // drain the boiled milk and chocolate
            this.IsEmpty = true;
        }
    }

    public void Boil()
    {
        if (!this.IsEmpty && !this.IsBoiled)
        {
            // bring the content to a boil
            this.IsBoiled = true;
        }
    }
}
