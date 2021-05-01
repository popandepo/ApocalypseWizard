using System;

namespace Code.Interfaces
{
    public interface IItem
    {
        Enum Name { get; set; }
        int Amount { get; set; }
        Enum ItemType { get; set; }
        Enum MainCategory { get; set; }
        Enum SubCategory { get; set; }
    }
}