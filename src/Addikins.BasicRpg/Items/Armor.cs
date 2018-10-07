using System.Collections.Generic;

namespace Addikins.BasicRpg.Items
{
    public class Armor : Equipment
    {
        public static List<Armor> AllArmorSets = new List<Armor>
        {
            new Armor("Scarf", 1, "A simple tattered scarf.", 0, 2),
            new Armor("Baseball Cap", 2, "Not your favorite team but it will do...", 0, 2),
            new Armor("Puffy Jacket", 5, "Embracing fluffiness!", 1, 5),
            new Armor("Battle Ready Armor", 15, "A brassiere of the highest quality!", 3, 3)
        };

        public int Defense { get; set; }

        public Armor(string name, int defense, string description, int minLevel, double weight)
            : base(name, minLevel, weight, description)
        {
            Defense = defense;
        }
    }
}
