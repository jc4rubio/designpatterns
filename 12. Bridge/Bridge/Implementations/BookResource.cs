namespace Bridge;

internal class BookResource(Book book, IResourceService resourceService) : IResource
{
    private readonly Book Book = book;
    private readonly IResourceService ResourceService = resourceService;

    public string GetImage() => this.ResourceService.GetImage(this.Book.Id);

    public string GetSnippet() => this.Book.Description;

    public string GetTitle() => this.Book.Title;

    public string GetUrl() => this.ResourceService.GetUrl(this.Book.Id);
}