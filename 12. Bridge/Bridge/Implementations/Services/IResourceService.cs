namespace Bridge;

internal interface IResourceService
{
    string GetImage(int resourceId);

    string GetUrl(int resourceId);
}
