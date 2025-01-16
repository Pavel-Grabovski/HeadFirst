namespace HeadFirst.IteratorAndLinkerPattern;

public class Waitress
{
    List<IMenu> menus = new List<IMenu>();

    public Waitress(params IMenu[] menus)
    {
        this.menus.AddRange(menus);
    }

    public void PrintMenu()
    {
        List<IMenu>.Enumerator menuIterator = menus.GetEnumerator();

        while (menuIterator.MoveNext())
        {
            IMenu menu = menuIterator.Current;
            PrintMenu(menu.CreateEnumerator());
        }


    }
    private void PrintMenu(IEnumerator<MenuItem> iterator)
    {
        while (iterator.MoveNext())
        {
            MenuItem menuItem = iterator.Current;
            Console.Write(menuItem.GetName() + ", ");
            Console.Write(menuItem.GetPrice() + " -- ");
            Console.Write(menuItem.GetDescription());
            Console.WriteLine();
        }
    }
    // другие методы
}