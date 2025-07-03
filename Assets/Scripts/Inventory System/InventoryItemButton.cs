using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryItemButton : MonoBehaviour
{
    [SerializeField] private Image _imgItemSprite;
    [SerializeField] private TMP_Text _txtItemCount;
    [SerializeField] private Button _button;

    public void SetButton(Sprite itemSprite, int itemCount)
    {
       _button.onClick.RemoveAllListeners();

        _imgItemSprite.sprite = itemSprite;
        _txtItemCount.text = $"x { itemCount}";
    }
}
