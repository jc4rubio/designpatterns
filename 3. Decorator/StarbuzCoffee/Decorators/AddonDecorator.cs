namespace StarbuzzCoffe;

internal abstract class AddonDecorator : Beberage
{
    public override abstract double Cost();
    public override abstract string Description();
}
