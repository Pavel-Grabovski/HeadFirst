namespace HeadFirst.TemplateMethod;

public class CoffeeWithHook : CaffeineBeverageWithHook
{
    public override void AddComponents()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    public override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    public override bool IsCustomerWantsCondiments()
    {
        string answer = GetUserInput();
        if(answer.ToLower() == "y")
            return true;

        return false;  
    }

    private string GetUserInput()
    {
        Console.Write("Would you like milk and sugar with your coffee? (y/n): ");

        string input = Console.ReadLine();

        return input;
    }
}
