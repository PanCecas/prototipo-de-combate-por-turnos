using System;

public enum ArmorClass
{
    Human,
    Beast,
    Hybrid,
    Any
}

public class Armor
{
    public string Name { get; set; }
    public int Defense { get; set; }
    public int Durability { get; set; }
    public ArmorClass Class { get; set; }

    public Armor(string name, int defense, int durability, ArmorClass armorClass)
    {
        Name = name;
        Defense = defense;
        Durability = durability;
        Class = armorClass;
    }

    public int ReduceDamage(int damage)
    {
        if (Durability > 0)
        {
            int reducedDamage = damage - (Defense / 2);
            reducedDamage = Math.Max(reducedDamage, 1);
            Durability--;
            return reducedDamage;
        }
        return damage;
    }

}
