namespace Iterator;

using System.Collections;

// DinnerMenu implementation uses an array. Arrays don't support IEnumerator<T>. A custom iterator is needed. (Customization based on Java, where Arrays doesn't support IEnumerator or equivalent (Iterator))
internal sealed class DinerMenuCustomIterator(MenuItem[] items) : IEnumerator<MenuItem>
{
    private readonly MenuItem[] _items = items;
    private int _position = 0;

    public MenuItem Current => _items[_position++];

    object IEnumerator.Current => this.Current;

    public void Dispose() { }

    public bool MoveNext() => _position < _items.Length && _items[_position] is not null;

    public MenuItem Next() => _items[_position++];

    public void Reset() => _position = 0;
}

// DinnerMenu implementation uses an array. Arrays don't support IEnumerator<T>. It can be adapted from IEnumerator

internal sealed class DinerMenuIterator(MenuItem[] items) : IEnumerator<MenuItem>
{
    private readonly IEnumerator _enumerator = items.GetEnumerator();

    public MenuItem Current => (MenuItem)_enumerator.Current;

    object IEnumerator.Current => this.Current;

    public void Dispose() { }

    public bool MoveNext() => this._enumerator.MoveNext() && this.Current is not null; // Null indicates that there are no more elements

    public MenuItem Next() => (MenuItem)this._enumerator.Current;

    public void Reset() => this._enumerator.Reset();
}
