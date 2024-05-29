namespace TemplateMethod.OthersExamples;

internal class Duck(string name, int weitht) : IComparable<Duck>
{
    public string Name { get; set; } = name;
    public int Weight { get; set; } = weitht;

    public override string ToString()
    {
        return this.Name + " weights " + this.Weight;
    }

    public int CompareTo(Duck? other) => Compare(this, other);

    private static int Compare(Duck? @this, Duck? other)
    {
        if (@this is null && other is null)
        {
            return 0;
        }

        if (@this is null)
        {
            return -1;
        }

        if (other is null)
        {
            return 1;
        }

        if (@this.Weight < other.Weight)
        {
            return -1;
        }
        else if (@this.Weight == other.Weight)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public override bool Equals(object? obj)
    {
        Duck? other = obj as Duck;

        return other is not null && this.CompareTo(other) == 0;
    }

    public override int GetHashCode() => this.Name.GetHashCode() ^ this.Weight.GetHashCode();

    public static bool operator ==(Duck left, Duck right) => left is null ? right is null : left.Equals(right);
    public static bool operator >(Duck left, Duck right) => Compare(left, right) > 0;
    public static bool operator >=(Duck left, Duck right) => Compare(left, right) >= 0;
    public static bool operator <(Duck left, Duck right) => Compare(left, right) < 0;
    public static bool operator <=(Duck left, Duck right) => Compare(left, right) <= 0;
    public static bool operator !=(Duck left, Duck right) => !(left == right);
}