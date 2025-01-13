namespace HeadFirst.IteratorAndLinkerPattern;

public class PancakeHouseMenuIterator : Iterator
{
    private readonly List<MenuItem> items;
    private int position = 0;

    public PancakeHouseMenuIterator(List<MenuItem> items)
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
        if (position >= items.Count || items[position] == null)
            return false;
        return true;
    }
}

