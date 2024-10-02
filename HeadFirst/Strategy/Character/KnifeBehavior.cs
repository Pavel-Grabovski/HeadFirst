namespace HeadFirst.Strategy.Character;

public class KnifeBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Удар ножом");
    }
}
