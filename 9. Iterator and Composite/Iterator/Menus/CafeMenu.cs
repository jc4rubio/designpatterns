namespace Iterator;

internal class CafeMenu : IMenu
{
    private readonly Dictionary<string, MenuItem> _menuItems = [];

    public CafeMenu()
    {
        this.AddItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
            true,
            3.99);

        this.AddItem("Soup of the day",
            "A cup of soup of the day, with a side salad",
            false,
            3.69);

        this.AddItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole",
            true,
            4.29);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new(name, description, vegetarian, price);
        this._menuItems.Add(name, menuItem);
    }

    public IEnumerator<MenuItem> CreateIterator() => this._menuItems.Values.GetEnumerator();
}
