using System;

public enum WeaponClass
{
    Human,
    Beast,
    Hybrid,
    Any
}

public class Weapon
{
    public string Name { get; set; }
    public int Power { get; set; }
    public int Durability { get; set; }
    public WeaponClass Class { get; set; }

    public Weapon(string name, int power, int durability, WeaponClass weaponClass)
    {
        Name = name;
        Power = power;
        Durability = durability;
        Class = weaponClass;
    }

    public void ReduceDurability()
    {
        Durability--;
    }

}
