using Proxy.ProtectionProxy;
using Proxy.VirtualProxy;

Console.WriteLine("Proxy pattern");
Console.WriteLine("-------------");

VirtualProxyTestDrive();

static void VirtualProxyTestDrive()
{
    Console.WriteLine("\n" + nameof(VirtualProxyTestDrive) + "\n");

    IBookParser proxy = new LazyBookParserProxy("Head First Design Patterns");

    string title = proxy.GetTitle();
    Console.WriteLine("Title: " + title);

    int pages = proxy.GetNumPages();
    Console.WriteLine("Pages: " + pages);
}

ProtectionProxyTestDrive();

static void ProtectionProxyTestDrive()
{
    Console.WriteLine("\n" + nameof(ProtectionProxyTestDrive) + "\n");

    IPerson joe = CreatePerson("Joe Bean");

    IPerson ownerProxy = DynamicProxyDecorator.DecorateViaComposition<IPerson, OwnerInterceptor>(joe);
    Console.WriteLine("Name is " + ownerProxy.GetName());

    ownerProxy.SetInterests("bowling, Go");
    Console.WriteLine("Interests set from owner proxy");

    try
    {
        ownerProxy.SetGeekRating(10);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Can't set rating from owner proxy. " + ex.Message);
    }

    Console.WriteLine("Rating is " + ownerProxy.GetGeekRating());

    IPerson nonOwnerProxy = DynamicProxyDecorator.DecorateViaComposition<IPerson, NonOwnerInterceptor>(joe);
    Console.WriteLine("Name is " + nonOwnerProxy.GetName());

    Console.WriteLine("Interests set from owner proxy");

    try
    {
        nonOwnerProxy.SetInterests("bowling, Go");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Can't set interests from non owner proxy. " + ex.Message);
    }
    nonOwnerProxy.SetGeekRating(3);
    Console.WriteLine("Rating set from non owner proxy");
    Console.WriteLine("Rating is " + nonOwnerProxy.GetGeekRating());
}

static IPerson CreatePerson(string name)
{
    Person person = new();
    person.SetName(name);
    person.SetGeekRating(7);

    return person;
}
