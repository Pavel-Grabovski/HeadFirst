using System.Collections;

namespace HeadFirst.IteratorAndLinkerPattern;

public class PancakeHouseMenuIEnumerator : IEnumerator<MenuItem>
{
    private readonly List<MenuItem> items;
    private int position = -1;

    public PancakeHouseMenuIEnumerator(List<MenuItem> items)
    {
        this.items = items;
    }

    public MenuItem Current => items[position];

    object IEnumerator.Current => items[position];

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        position++;

        if (position >= items.Count || items[position] == null)
            return false;

        return true;
    }

    public void Reset()
    {
        position = -1;
    }
}

