namespace HeadFirst.Strategy.Character;

public abstract class Character
{
    protected private IWeaponBehavior WeaponBehavior;
    public virtual void Fight()
    {
        WeaponBehavior.UseWeapon();
    }

    public void SetWeapon(IWeaponBehavior weapon)
    {
        WeaponBehavior = weapon;
    }
}