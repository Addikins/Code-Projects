using System;

namespace Addikins.BasicRpg.Items
{
    public abstract class Equipment : IItem
    {
        protected Equipment(string name, int minLevel, double weight, string description)
        {
            Name = name;
            MinLevel = minLevel;
            Weight = weight;
            Description = description;
        }

        public string Name { get; set; }
        public int MinLevel { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }
    }
}
