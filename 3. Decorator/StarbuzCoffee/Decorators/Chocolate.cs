namespace StarbuzzCoffe;

internal class Chocolate(Beberage beberage) : AddonDecorator
{
    private readonly Beberage beberage = beberage;

    public override double Cost() => this.beberage.Cost() + 0.75;
    public override string Description() => this.beberage.Description() + " + chocolate";
}
