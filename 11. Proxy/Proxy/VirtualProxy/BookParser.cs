namespace Proxy.VirtualProxy;

using System;
using System.Threading.Tasks;

internal class BookParser : IBookParser
{
    private readonly string book;
    private readonly int numPages;

    public BookParser(string book)
    {     
        // Expensive parsing
        Task.Delay(TimeSpan.FromSeconds(30));
        this.book = book;
        this.numPages = 500;
    }

    public string GetTitle() => this.book;

    public int GetNumPages() => this.numPages;
}
