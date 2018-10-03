using System.Collections.Generic;

namespace CodingwithPSVM
{
    public class Weapon:IItem
    {
        public static List<Weapon> AllWeapons = new List<Weapon>
        {
            new Weapon("Spatula", 1, "A flimsy Rubber Spatula", 0, 1),
            new Weapon("Steel Coffee Mug", 3, "A little wake up call", 0, 2),
            new Weapon("Yo-yo", 5, "A basic yarn Yo-yo", 1, 1),
            new Weapon("Fan", 15, "It's sharper than it looks", 3, 1),
        };

        public int Attack { get; set; }
        public int MinLevel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        public Weapon(string name, int attack, string description, int minLevel, double weight)
        {
            Name = name;
            Attack = attack;
            Description = description;
            MinLevel = minLevel;
            Weight = weight;
        }
    }
}