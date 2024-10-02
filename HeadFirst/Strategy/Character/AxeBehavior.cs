namespace HeadFirst.Strategy.Character;

public class AxeBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Удар топором");
    }
}
