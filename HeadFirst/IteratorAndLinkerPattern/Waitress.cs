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
    public void printMenu()
    {
        var pancakeIterator = pancakeHouseMenu.CreateIterator();
        var dinerIterator = dinerMenu.CreateIterator();
        Console.WriteLine("MENU\n----\nBREAKFAST");
        printMenu(pancakeIterator);
        Console.WriteLine("\nLUNCH");
        PrintMenu(dinerIterator);
    }
    private void PrintMenu(Iterator iterator)
    {
        while (iterator.HasNext())
        {
            MenuItem menuItem = iterator.Next();
            Console.WriteLine(menuItem.GetName() + ", ");
            Console.WriteLine(menuItem.GetPrice() + " -- ");
            Console.WriteLine(menuItem.GetDescription());
        }
    }
    // другие методы
}