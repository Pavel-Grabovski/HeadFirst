namespace HeadFirst.IteratorAndLinkerPattern;

public class MenuItem
{
    private readonly string _name;
    private readonly string _description;
    private readonly bool _vegetarian;
    private readonly double _price;

    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        _name = name;
        _description = description;
        _vegetarian = vegetarian;
        _price = price;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public double GetPrice()
    {
        return _price;
    }

    public bool IsVegetarian()
    {
        return _vegetarian;
    }
}
