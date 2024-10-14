namespace HeadFirst.Decorator;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage { get; set; }

    //public new abstract string GetDescription();
}
