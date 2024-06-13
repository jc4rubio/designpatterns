namespace Proxy.ProtectionProxy;

internal class Person : IPerson
{
    private string name = default!;
    private string gender = default!;
    private string interests = default!;
    private int rating;
    private int ratingCount = 0;

    public string GetName() => this.name;
    public string GetGender() => this.gender;
    public string GetInterests() => this.interests;
    public int GetGeekRating() => rating switch
    {
        0 => 0,
        _ => rating / ratingCount
    };

    public void SetName(string name) => this.name = name;
    public void SetGender(string gender) => this.gender = gender;
    public void SetInterests(string interests) => this.interests = interests;
    public void SetGeekRating(int rating)
    {
        this.rating += rating;
        this.ratingCount++;
    }
}
