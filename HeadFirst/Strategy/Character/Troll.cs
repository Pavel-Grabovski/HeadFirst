namespace HeadFirst.Strategy.Character;

public class Troll : Character
{
    public Troll()
    {
        WeaponBehavior = new AxeBehavior();
    }
}
