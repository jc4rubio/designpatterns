namespace Proxy.ProtectionProxy;

internal interface IPerson
{
    string GetName();
    string GetGender();
    string GetInterests();
    int GetGeekRating();

    void SetName(string name);
    void SetGender(string gender);
    void SetInterests(string interests);
    void SetGeekRating(int rating);
}
