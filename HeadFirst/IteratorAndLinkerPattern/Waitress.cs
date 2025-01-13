using System.Collections;

namespace HeadFirst.IteratorAndLinkerPattern;

public class Waitress
{
    PancakeHouseMenu pancakeHouseMenu;
    DinerMenu dinerMenu;
    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
        this.pancakeHouseMenu = pancakeHouseMenu;
        this.dinerMenu = dinerMenu;
    }
    public void PrintMenu()
    {
        IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.GetEnumerator();
        IEnumerator<MenuItem> dinerIterator = dinerMenu.GetEnumerator();
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