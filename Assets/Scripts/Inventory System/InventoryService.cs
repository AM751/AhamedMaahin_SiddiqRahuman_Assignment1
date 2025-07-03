using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class InventoryService : MonoBehaviour
{

    [SerializeField] private int _maxPerItem = 5;
    //Dictionary to keep a track of all the items:

    private Dictionary<ItemSO, int> inventoryItems = new Dictionary<ItemSO, int>();

    public event Action <ItemSO> OnItemAdded;

    public event Action<Dictionary<ItemSO, int>> OnInventorySystemLoaded;
    public bool AddToInventory(ItemSO itemData)
    {
        if (inventoryItems.ContainsKey(itemData))
        {
            if (inventoryItems[itemData] >= _maxPerItem)
            {
                return false;
            }
            else
            {
                inventoryItems[itemData]++;
                OnItemAdded(itemData);
                return true;
            }
        }
        else
        {
            inventoryItems.Add(itemData, 1);
            OnItemAdded?.Invoke(itemData);
            return true;
        }

        
        

        
    }

    

    public void LoadInventory()
    {
        OnInventorySystemLoaded?.Invoke(inventoryItems);
    }

   
}
