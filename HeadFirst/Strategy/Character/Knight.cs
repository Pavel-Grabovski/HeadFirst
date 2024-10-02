namespace HeadFirst.Strategy.Character;

public class Knight : Character
{
    public Knight()
    {
        WeaponBehavior = new SwordBehavior();
    }
}