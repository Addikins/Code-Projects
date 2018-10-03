using System.Collections.Generic;

namespace CodingwithPSVM
{
    public class EnemyClass
    {
        public static List<EnemyClass> AllClasses = new List<EnemyClass>
        {
            new EnemyClass("Whelp", 50, 1, 2, 25),
            new EnemyClass("Bruiser", 100, 3, 4, 50),
        };

        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Exp { get; set; }

        public EnemyClass(string name, int health, int defense, int attack, int exp)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack;
            Exp = exp;
        }

        public override string ToString()
        {
            return $"{Name} - Health: {Health}, Defense: {Defense}, Attack: {Attack}";
        }
    }
}
