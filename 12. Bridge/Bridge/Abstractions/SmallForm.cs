namespace Bridge;

internal class SmallForm(IResource resource) : View(resource)
{
    public override string Show()
    {
        string title = this.Resource.GetTitle();
        string snippet = this.Resource.GetSnippet();
        string url = this.Resource.GetUrl();

        return $"""

            --{title}-----
            [-{snippet}---]
            [----{url}----]

        """;
    }
}
