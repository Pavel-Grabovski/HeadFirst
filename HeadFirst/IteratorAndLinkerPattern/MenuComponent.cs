namespace HeadFirst.IteratorAndLinkerPattern;

public abstract class MenuComponent
{
    public abstract void Add(MenuComponent menuComponent);

    public abstract void Remove(MenuComponent menuComponent);

    public abstract MenuComponent GetChild(int index);

    public abstract string GetName();

    public abstract string GetDescription();

    public abstract string GetPrice();

    public abstract bool IsVegetarian();

    public abstract void Print();
}
