using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingwithPSVM.Items
{
    public abstract class Equipment : IItem
    {
        public Equipment(string name, int minLevel, double weight, string description)
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
