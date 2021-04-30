using System.Collections.Generic;
using Code.Classes;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> inventory;

    public void Start()
    {
        inventory.Add(new Item());
    }
}