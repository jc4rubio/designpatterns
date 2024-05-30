namespace Iterator;

internal interface IMenu
{
    IEnumerator<MenuItem> CreateIterator();
}
