using System;
using Code.Interfaces;

namespace Code.Classes
{
    [Serializable]
    public class Item : IItem
    {
        public Item(string name = "Empty slot", int amount = 0)
        {
            Name = name;
            Amount = amount;
            //Test = BulletType.Arcing;
        }

        //public Enum Test { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}