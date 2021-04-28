using Code.Interfaces;
using System;

namespace Code.Classes
{
    [Serializable]
    public class Item : IItem
    {

        public string Name { get; set; }
        public int Amount { get; set; }

        public Item(string name = "Empty slot", int amount = 0)
        {
            Name = name;
            Amount = amount;
        }
    }
}
