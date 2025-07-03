using System.Runtime.InteropServices;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{

    [SerializeField] private ItemSO _itemData;


    void Start()
    {
        if (!_itemData) return;

        //if we have a data asset, we will be creating an visual of that item:

        var objVisual = Instantiate(_itemData.itemPrefab, transform);
        objVisual.transform.position = transform.position;
        objVisual.transform.rotation = transform.rotation;
    }
    public void Interact()
    {


        if (ServiceLocator.instance.GetService<InventoryService>().AddToInventory(_itemData))
        {
            Debug.Log($"{_itemData.name} is  Collected");
            Destroy (gameObject);
        }
        else
        {
            Debug.Log($"You cannot collect anymore {_itemData.name}s!!");
        }
    }

   
}
