class Item
{
    string Name { get; set; }
    Rarity rarity { get; set; }

    public int GetItemValue(Item item) => item.GetType().Name switch
    {
        
    };        
}

class Weapon : Item
{
    int Damage { get; set; }
    WeaponType weaponType { get; set; }
}

class Armor : Item
{
    int Defense { get; set; }
    ArmorType armorType { get; set; }
}

class Consumable : Item
{
    string Effect { get; set; }
    int Duration { get; set; }
}

enum Rarity
{
    Common = 10, Uncommon = 50, Rare = 200, Epic = 1000, Legendary = 5000
}

enum WeaponType
{
    Sword, Bow, Staff
}

enum ArmorType
{
    Helmet, Chest, Boots
}

enum CharacterClass
{
    Warrior, Archer, Mage
}