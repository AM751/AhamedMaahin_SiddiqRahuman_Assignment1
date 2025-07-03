using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUISO : MonoBehaviour
{

    [SerializeField] private InventoryService _inventoryService;

    [Header("UI Refs")]
    [SerializeField] private Transform _inventoryItemContainer;
    [SerializeField] private InventoryItemButton _inventoryItemButton;

    [Header("UI Refs - Item Information")]
    [SerializeField] private Image _itemImage;
    [SerializeField] private TMP_Text _txtItemName;
    [SerializeField] private TMP_Text _txtItemDescription;
    [SerializeField] private TMP_Text _txtItemValue;
    void OnEnable()
     {
        _inventoryService.OnInventorySystemLoaded += OnInventoryLoaded;  
     }

    void OnDisable()
    {
        _inventoryService.OnInventorySystemLoaded -= OnInventoryLoaded;
    }

    private void OnInventoryLoaded (Dictionary<ItemSO, int> items)
    {
        //Clearing the List
        foreach (Transform item in _inventoryItemContainer)
        {
            Destroy(item);
        }

        //Populate the list with items
        foreach (ItemSO item in items.Keys)
        {
            //Creating a new button:
            var button = Instantiate(_inventoryItemButton, _inventoryItemContainer);
            button.SetButton(item.itemSprite, items[item]);
        }
    }
}
