namespace Iterator;

internal class MenuItem(string name, string description, bool vegetarian, double price)
{
    public string Name { get; init; } = name;
    public string Description { get; init; } = description;
    public bool Vegetarian { get; init; } = vegetarian;
    public double Price { get; init; } = price;
}
