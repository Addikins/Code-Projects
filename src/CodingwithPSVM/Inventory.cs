using System.Collections.Generic;

namespace CodingwithPSVM
{
    public class Inventory
    {
        public List<IItem> Items = new List<IItem>();
        public int MaxSize { get; set; } = 5;

        public void AddItem(IItem item)
        {
            if (Items.Count >= MaxSize)
            {
                return;
            }

            Items.Add(item);
        }
    }
}
