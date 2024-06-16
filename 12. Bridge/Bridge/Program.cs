using Bridge;

Console.WriteLine("Bridge pattern");
Console.WriteLine("--------------");

BridgeTestDrive();

static void BridgeTestDrive()
{
    ResourceService resourceService = new();
    
    Artist artist = new("Twenty one pilots");
    ArtistResource artistResource = new(artist, resourceService);
    LongForm longForm = new(artistResource);

    Console.WriteLine(longForm.Show());

    Book book = new("Lord of the rings");
    BookResource bookResource = new(book, resourceService);
    SmallForm smallForm = new(bookResource);

    Console.WriteLine(smallForm.Show());
}
