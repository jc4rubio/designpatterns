namespace Composite;

internal class MenuItem(string name, string description, bool vegetarian, double price) : MenuComponent
{
    private readonly string _name = name;
    private readonly string _description = description;
    private readonly bool _vegetarian = vegetarian;
    private readonly double _price = price;

    public override string GetName() => this._name;
    public override string GetDescription() => this._description;
    public override double GetPrice() => this._price;
    public override bool IsVegetarian() => this._vegetarian;

    public override void Print()
    {
        Console.Write("   " + this.GetName());
        if (this.IsVegetarian())
        {
            Console.Write("(v)");
        }
        Console.WriteLine(", " + this.GetPrice());
        Console.WriteLine("    -- " + this.GetDescription());
    }
}
