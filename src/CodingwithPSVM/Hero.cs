using System;
using CodingwithPSVM.Items;

namespace CodingwithPSVM
{
    public class Hero : Fighter
    {

        public Hero(string name, HeroClass heroClass, Armor armor, Weapon weapon)
        {
            Name = name;
            HeroClass = heroClass;
            Armor = armor;
            Weapon = weapon;

            MaxHealth = heroClass.Health;
            Health = heroClass.Health;
        }

        public string Name { get; set; }
        public HeroClass HeroClass { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public Inventory Inventory { get; set; }

        public int MaxHealth { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }

        private void LevelUp()
        {
            Inventory.MaxSize++;
            Level++;
            MaxHealth += 100;
        }

        public override void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public void AddExp(int amount)
        {
            Exp += amount;
            while (Exp > Math.Pow(Level * 10, 1.25))
            {
                LevelUp();
            }
        }

        public override int GetDefense()
        {
            return HeroClass.Defense + Armor.Defense;
        }

        public int GetAttack()
        {
            return HeroClass.Attack + Weapon.Attack;
        }

        public string GetStatus()
        {
            return $@"Status:
{Name} the {HeroClass.Name}
Level:{Level} Exp:{Exp}
Health:{Health}/{MaxHealth}    Defense:{GetDefense()}    Attack:{GetAttack()}
Armorset: {Armor.Name} ({Armor.Description})
Weapon: {Weapon.Name} ({Weapon.Description})";
        }
    }
}
