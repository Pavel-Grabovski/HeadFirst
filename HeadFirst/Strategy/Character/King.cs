namespace HeadFirst.Strategy.Character;

public class King : Character
{
    public King()
    {
        WeaponBehavior = new KnifeBehavior();
    }
}
