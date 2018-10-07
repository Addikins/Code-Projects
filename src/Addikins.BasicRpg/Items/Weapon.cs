using System.Collections.Generic;

namespace Addikins.BasicRpg.Items
{
    public class Weapon : Equipment
    {
        public static List<Weapon> AllWeapons = new List<Weapon>
        {
            new Weapon("Spatula", 1, "A flimsy Rubber Spatula", 0, 1),
            new Weapon("Steel Coffee Mug", 3, "A little wake up call", 0, 2),
            new Weapon("Yo-yo", 5, "A basic yarn Yo-yo", 1, 1),
            new Weapon("Fan", 15, "It's sharper than it looks", 3, 1),
        };

        public int Attack { get; set; }

        public Weapon(string name, int attack, string description, int minLevel, double weight)
            : base(name, minLevel, weight, description)
        {
            Attack = attack;
        }
    }
}
