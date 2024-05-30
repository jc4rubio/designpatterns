namespace Iterator;

internal class PancakeHouseMenu : IMenu
{
    private readonly List<MenuItem> _menuItems;
    
    public PancakeHouseMenu()
    {
        this._menuItems = [];

        this.AddItem("K&B's Pancake Breakfast",
            "Pancakes with scrambled eggs and toast",
            true,
            2.99);

        this.AddItem("Regular Pancake Breakfast",
            "Pancakes with fried eggs, sausage",
            false,
            2.99);

        this.AddItem("Blueberry Pancakes",
            "Pancakes made with fresh blueberries",
            true,
            3.49);

        this.AddItem("Waffles",
            "Waffles with your choice of blueberries or strawberries",
            true,
            3.59);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new(name, description, vegetarian, price);
        this._menuItems.Add(menuItem);
    }

    public IEnumerator<MenuItem> CreateIterator() => this._menuItems.GetEnumerator();
}