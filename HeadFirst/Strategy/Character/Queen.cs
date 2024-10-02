namespace HeadFirst.Strategy.Character;

public class Queen : Character
{
    public Queen()
    {
        WeaponBehavior = new BowAndArrowBehavior();
    }
}
