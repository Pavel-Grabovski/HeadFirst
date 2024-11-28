namespace HeadFirst.TemplateMethod;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddComponents();
    }

    public void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    public void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    public abstract void Brew();

    public abstract void AddComponents();
}
