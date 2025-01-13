namespace HeadFirst.IteratorAndLinkerPattern;

public class DinerMenuIterator : Iterator
{
    private readonly MenuItem[] items;
    private int position = 0;

    public DinerMenuIterator(MenuItem[] items)
    {
        this.items = items;
    }

    public MenuItem Next()
    {
        MenuItem menuItem = items[position];
        position = position + 1;
        return menuItem;
    }

    public bool HasNext()
    {
        if (position >= items.Length || items[position] == null)
            return false;
        return true;
    }
}

