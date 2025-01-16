using System.Collections;

namespace HeadFirst.IteratorAndLinkerPattern;

public class Waitress
{
    IMenu pancakeHouseMenu;
    IMenu dinerMenu;
    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
    {
        this.pancakeHouseMenu = pancakeHouseMenu;
        this.dinerMenu = dinerMenu;
    }
    public void PrintMenu()
    {
        IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateEnumerator();
        IEnumerator<MenuItem> dinerIterator = dinerMenu.CreateEnumerator();
        Console.WriteLine("MENU\n----\nBREAKFAST");
        PrintMenu(pancakeIterator);
        Console.WriteLine("\nLUNCH");
        PrintMenu(dinerIterator);
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