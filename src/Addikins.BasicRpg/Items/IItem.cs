using System;

namespace Addikins.BasicRpg.Items
{
    public interface IItem
    {
        string Name { get; set; }
        int MinLevel { get; set; }
        double Weight { get; set; }
    }
}
