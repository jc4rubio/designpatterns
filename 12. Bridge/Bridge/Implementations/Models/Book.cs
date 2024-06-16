namespace Bridge;

internal class Book(string title)
{
    public int Id { get; set; }
    public string Title { get; set; } = title;
    public string Author { get; set; } = default!;
    public string Description { get; set; } = default!;
}
