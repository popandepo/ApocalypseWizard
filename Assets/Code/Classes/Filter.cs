using System;

public class Filter
{
    public Enum TargetItem { get; set; }
    public int TargetInventory { get; set; }

    public Filter(Enum targetItem, int targetInventory)
    {
        TargetItem = targetItem;
        TargetInventory = targetInventory;
    }
}
