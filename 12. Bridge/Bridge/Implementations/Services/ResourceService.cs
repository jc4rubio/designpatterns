namespace Bridge;

internal class ResourceService : IResourceService
{
    public string GetImage(int resourceId)
    {
        return "<Image>";
    }

    public string GetUrl(int resourceId)
    {
        return $"www.myresources.com/{resourceId}";
    }
}
