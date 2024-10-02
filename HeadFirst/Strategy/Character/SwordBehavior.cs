namespace HeadFirst.Strategy.Character;

public class SwordBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Удар мечом");
    }
}
