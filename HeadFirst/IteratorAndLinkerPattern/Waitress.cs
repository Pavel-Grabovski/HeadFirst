namespace HeadFirst.IteratorAndLinkerPattern;

public class Waitress
{
    MenuComponent allMenus;

    public Waitress(MenuComponent menuComponent )
    {
        allMenus = menuComponent;
    }

    public void PrintMenu()
    {
        allMenus.Print();
    }
}