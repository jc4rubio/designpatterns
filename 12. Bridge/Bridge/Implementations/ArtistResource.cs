namespace Bridge;

internal class ArtistResource(Artist artist, IResourceService resourceService) : IResource
{
    private readonly Artist Artist = artist;
    private readonly IResourceService ResourceService = resourceService;

    public string GetImage() => this.ResourceService.GetImage(this.Artist.Id);

    public string GetSnippet() => this.Artist.Biography;

    public string GetTitle() => this.Artist.Name;

    public string GetUrl() => this.ResourceService.GetUrl(this.Artist.Id);
}