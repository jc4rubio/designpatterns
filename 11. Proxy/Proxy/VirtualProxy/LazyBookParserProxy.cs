namespace Proxy.VirtualProxy;

internal class LazyBookParserProxy(string book) : IBookParser
{
    private readonly string book = book;
    private BookParser? bookParser = null;

    public string GetTitle()
    {
        this.bookParser ??= new BookParser(this.book);
        return this.bookParser.GetTitle();
    }

    public int GetNumPages()
    {
        this.bookParser ??= new BookParser(this.book);
        return this.bookParser.GetNumPages();
    }
}
