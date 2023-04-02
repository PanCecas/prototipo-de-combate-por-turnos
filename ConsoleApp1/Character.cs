using System;
using System.Collections.Generic;

public enum CharacterClass
{
    Human,
    Beast,
    Hybrid
}

public class Character
{
    public string Name { get; }
    public int MaxHP { get; }
    public int HP { get; private set; }
    public int Defense { get; }
    public CharacterClass Class { get; }

    public Armor EquippedArmor { get; private set; } = new Armor("", 0, 0, ArmorClass.Human);
    public Weapon EquippedWeapon { get; private set; } = new Weapon("", 0, 0, WeaponClass.Human);

    public Character(string name, int maxHP, int defense, int power, CharacterClass characterClass)
    {
        if (maxHP < 1)
        {
            throw new ArgumentException("MaxHP must be at least 1.");
        }
        if (defense < 0)
        {
            throw new ArgumentException("Defense cannot be negative.");
        }
        if (power < 1)
        {
            throw new ArgumentException("Power must be at least 1.");
        }

        Name = name;
        MaxHP = maxHP;
        HP = maxHP;
        Defense = defense;
        Class = characterClass;
        EquippedArmor = new Armor("", 0, 0, ArmorClass.Human);
        EquippedWeapon = new Weapon("", 0, 0, WeaponClass.Human);
    }

    public void EquipArmor(Armor armor)
    {
        if (armor.Class != EquippedArmor.Class)

        {
            throw new ArgumentException("Armor class does not match character class.");
        }

        EquippedArmor = armor;
    }

    public void EquipWeapon(Weapon weapon)
    {
        if (weapon.Class != EquippedWeapon.Class)

        {
            throw new ArgumentException("Weapon class does not match character class.");
        }

        EquippedWeapon = weapon;
    }
}

