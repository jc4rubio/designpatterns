namespace Iterator;

internal class DinerMenu : IMenu
{
    private readonly MenuItem[] _menuItems;
    
    private int _numberOfItems = 0;

    private const int MAX_ITEMS = 6;

    public DinerMenu()
    {
        this._menuItems = new MenuItem[MAX_ITEMS];

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
        if (this._numberOfItems >= MAX_ITEMS)
        {
            Console.WriteLine("Sorry, menu is full! Can't add item to menu");
        }
        else
        {
            this._menuItems[this._numberOfItems] = menuItem;
            this._numberOfItems++;
        }
    }

    public IEnumerator<MenuItem> CreateIterator() => new DinerMenuIterator(this._menuItems);

    // Alternative iterator
    public IEnumerator<MenuItem> CreateCustomIterator() => new DinerMenuCustomIterator(this._menuItems);
}
