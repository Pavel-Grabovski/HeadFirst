namespace HeadFirst.TemplateMethod;

public class TeaWithHook : CaffeineBeverageWithHook
{
    public override void AddComponents()
    {
        Console.WriteLine("Adding lemon");

    }

    public override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    public override bool IsCustomerWantsCondiments()
    {
        string answer = GetUserInput();
        if (answer.ToLower() == "y")
            return true;

        return false;
    }

    private string GetUserInput()
    {
        Console.Write("Would you like lemon with your tea? (y/n): ");

        string input = Console.ReadLine();

        return input;
    }
}
