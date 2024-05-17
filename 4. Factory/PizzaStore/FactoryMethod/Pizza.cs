namespace PizzaStore.FactoryMethod;

internal abstract class Pizza
{
    public string Name { get; init;  } = default!;
    public string Dough { get; set; } = default!;
    public string Sauce { get; set; } = default!;
    public IEnumerable<string> Toppings { get; set; } = [];
    public DateTime OrderTimestamp { get; } = DateTime.UtcNow;

    public override string ToString()
    {
        return $@"
            Name: {this.Name}
            Dough: { this.Dough}
            Sauce: { this.Sauce}
            Toppings: { string.Join(", ", this.Toppings)}
            Ordered at {this.OrderTimestamp:g}";
    }
}
