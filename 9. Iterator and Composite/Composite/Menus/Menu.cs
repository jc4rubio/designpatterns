namespace Composite;

internal class Menu(string name, string description) : MenuComponent
{
    private readonly List<MenuComponent> _menuComponets = [];
    private readonly string _name = name;
    private readonly string _description = description;

    public override void Add(MenuComponent menuComponent) => this._menuComponets.Add(menuComponent);

    public override void Remove(MenuComponent menuComponent) => this._menuComponets.Remove(menuComponent);

    public override MenuComponent GetChild(int i) => this._menuComponets[i];

    public override string GetName() => this._name;

    public override string GetDescription() => this._description;

    public override void Print()
    {
        Console.Write("\n" + this.GetName());
        Console.WriteLine(", " + this.GetDescription());
        Console.WriteLine("---------------");

        foreach (MenuComponent menuComponent in this._menuComponets)
        {
            menuComponent.Print();
        }
    }
}
