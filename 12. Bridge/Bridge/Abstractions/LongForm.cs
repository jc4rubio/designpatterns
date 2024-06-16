namespace Bridge;

internal class LongForm(IResource resource) : View(resource)
{
    public override string Show()
    {
        string title = this.Resource.GetTitle();
        string image = this.Resource.GetImage();
        string snippet = this.Resource.GetSnippet();
        string url = this.Resource.GetUrl();

        return $"""

            ------------------{title}----------------
            [-----------------{image}---------------]
            [-----------------{snippet}-------------]
            [-----------------{url}-----------------]

        """;
    }
}
