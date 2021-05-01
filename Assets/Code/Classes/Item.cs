using Code.Interfaces;
using System;

namespace Code.Classes
{
    [Serializable]
    public class Item : IItem
    {
        public Enum Name { get; set; }
        public int Amount { get; set; }
        public Enum ItemType { get; set; }
        public Enum MainCategory { get; set; }
        public Enum SubCategory { get; set; }

        public Item(Enum name = null, int amount = -1, Enum itemType = null, Enum mainCategory = null, Enum subCategory = null)
        {
            Name = name;
            Amount = amount;
            ItemType = itemType;
            MainCategory = mainCategory;
            SubCategory = subCategory;
        }
    }
}