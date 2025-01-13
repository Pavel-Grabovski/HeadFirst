using System.Collections;

namespace HeadFirst.IteratorAndLinkerPattern;

public class DinerMenuEnumerator : IEnumerator<MenuItem>
{
    private readonly MenuItem[] items;
    private int position = -1;

    public MenuItem Current => items[position];

    object IEnumerator.Current => items[position];

    public DinerMenuEnumerator(MenuItem[] items)
    {
        this.items = items;
    }

    public bool MoveNext()
    {
        position++;

        if (position >= items.Length || items[position] == null)
            return false;

        return true;
    }

    public void Reset()
    {
        position = -1;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

