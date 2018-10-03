using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingwithPSVM
{
    public class Food : IItem
    {
        public static List<Food> AllFood = new List<Food>
        {
            new Food("Redcap Mushroom", -5, .3, "Great for Potions, not so much for eating...", 0),
            new Food("Chocolate", 3, .2, "Savory snack, and useful ingredient", 0),
            new Food("Mango", 5, .3, "Refreshingly tropical", 0),
            new Food("Coffee", 15, .5, "What else do you need", 0),
        };

        public string Name { get; set; }
        public int Health { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }
        public int MinLevel { get; set; }

        public Food(string name, int health, double weight, string description, int minlevel)
        {
            Name = name;
            Health = health;
            Weight = weight;
            Description = description;
            MinLevel = minlevel;
        }
    }
}
