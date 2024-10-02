namespace HeadFirst.Strategy.Character;

public class BowAndArrowBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Выстрел из лука");
    }
}