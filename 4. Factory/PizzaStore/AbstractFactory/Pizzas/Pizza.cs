namespace PizzaStore.AbstractFactory;

using System.Text;
using static Utils;

internal abstract class Pizza
{
    public string Name => GetSplitCamelCaseName(this);
    public IDough Dough { get; set; } = default!;
    public ISauce? Sauce { get; set; } = default!;
    public ICheese? Cheese { get; set; } = default!;
    public IClam? Clam { get; set; } = default!;
    public IPepperoni? Pepperoni { get; set; } = default!;
    public IEnumerable<IVeggies> Veggies { get; set; } = [];
    public DateTime OrderTimestamp { get; } = DateTime.UtcNow;

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Plaze pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine(this.Name);

        if (this.Dough is not null)
        {
            sb.AppendLine($" -{nameof(this.Dough)}: {GetSplitCamelCaseName(this.Dough)}");
        }

        if (this.Sauce is not null)
        {
            sb.AppendLine($" -{nameof(this.Sauce)}: {GetSplitCamelCaseName(this.Sauce)}");
        }

        if (this.Cheese is not null)
        {
            sb.AppendLine($" -{nameof(this.Cheese)}: {GetSplitCamelCaseName(this.Cheese)}");
        }

        if (this.Clam is not null)
        {
            sb.AppendLine($" -{nameof(this.Clam)}: {GetSplitCamelCaseName(this.Clam)}");
        }

        if (this.Pepperoni is not null)
        {
            sb.AppendLine($" -{nameof(this.Pepperoni)}: {GetSplitCamelCaseName(this.Pepperoni)}");
        }

        if (this.Veggies.Any())
        {
            sb.AppendLine($" -{nameof(this.Veggies)}: {string.Join(", ", this.Veggies.Select(GetSplitCamelCaseName))}");
        }

        sb.AppendLine($"Ordered at {this.OrderTimestamp.ToString("g")}");

        return sb.ToString();
    }
}
