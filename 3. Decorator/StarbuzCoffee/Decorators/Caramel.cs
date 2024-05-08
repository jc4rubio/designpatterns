namespace StarbuzzCoffe;

internal class Caramel(Beberage beberage) : AddonDecorator
{
    private readonly Beberage beberage = beberage;

    public override double Cost() => this.beberage.Cost() + 0.5;
    public override string Description() => this.beberage.Description() + " + caramel";
}
