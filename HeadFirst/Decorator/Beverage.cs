namespace HeadFirst.Decorator;
public abstract class Beverage
{
    private BeverageSizeEnum _size;

    protected string Description = "Unknown Beverage";

    public abstract decimal Cost();

    public virtual string GetDescription() => Description;

    public void SetSize(BeverageSizeEnum size)
    {
        _size = size;
    }

    public BeverageSizeEnum GetSize() => _size;
}