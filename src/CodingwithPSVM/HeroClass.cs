using System.Collections.Generic;

namespace CodingwithPSVM
{
    public class HeroClass
    {
        public static List<HeroClass> AllClasses = new List<HeroClass>
        {
            new HeroClass("Knight", 300, 1, 5),
            new HeroClass("Warrior", 400, 3, 6),
        };

        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public HeroClass(string name, int health, int defense, int attack)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack;
        }

        public override string ToString()
        {
            return $"{Name} - Health: {Health}, Defense: {Defense}, Attack: {Attack}";
        }
    }
}
