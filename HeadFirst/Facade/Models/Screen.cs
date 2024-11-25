

namespace HeadFirst.Facade.Models;

public class Screen
{
    internal void Down()
    {
        Console.WriteLine($"Theater Screen going down");
    }

    internal void Up()
    {
        Console.WriteLine($"Theater Screen going up");
    }
}
