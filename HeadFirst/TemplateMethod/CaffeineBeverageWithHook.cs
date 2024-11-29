namespace HeadFirst.TemplateMethod;

public abstract class CaffeineBeverageWithHook
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();

        if(IsCustomerWantsCondiments())
        {
            AddComponents();
        }
    }
    public abstract void Brew();

    public abstract void AddComponents();

    public void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    public void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    public virtual bool IsCustomerWantsCondiments()
    {
        return true;
    }
}
