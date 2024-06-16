namespace Bridge;

internal class Artist(string name)
{
    public int Id { get; set; }
    public string Name { get; set; } = name;
    public string Biography { get; set; } = default!;
}
