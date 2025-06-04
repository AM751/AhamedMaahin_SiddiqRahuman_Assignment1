using UnityEngine;
using TMPro;
public class CoinsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreUI;
    private CollectingController _collectingController;

    void OnEnable()
    {
        _collectingController = FindObjectOfType<CollectingController>();
        _collectingController.coinsPlus += coinsPlus;

    }

    void OnDisable()
    {
        _collectingController.coinsPlus -= coinsPlus;
    }

    private void coinsPlus(int totalCoin)
    {
        _scoreUI.text = "Coins: " + totalCoin;
    }
}
