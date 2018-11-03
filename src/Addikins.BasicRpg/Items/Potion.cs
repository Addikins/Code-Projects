using System;
using System.Collections.Generic;

namespace Addikins.BasicRpg.Items
{
    public class Potion : IItem
    {
        public static List<Potion> AllPots = new List<Potion>
        {
            new Potion("Minor Healing Potion", 25, .5, 0),
            new Potion("Basic Healing Potion", 50, .5, 2),
            new Potion("Major Healing Potion", 75, .5, 5),
            new Potion("Super Healing Potion", 100, .5, 10)
        };

        public string Name { get; set; }
        public int Health { get; set; }
        public double Weight { get; set; }
        public int MinLevel { get; set; }

        public Potion(string name, int health, double weight, int minLevel)
        {
            Name = name;
            Health = health;
            Weight = weight;
            MinLevel = minLevel;
        }
    }
}
