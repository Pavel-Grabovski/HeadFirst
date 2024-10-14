namespace HeadFirst.Decorator;
public abstract class Beverage
{
    protected string Description = "Unknown Beverage";

    public abstract decimal Cost();

    public virtual string GetDescription() => Description;
}