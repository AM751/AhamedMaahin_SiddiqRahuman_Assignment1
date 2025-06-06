using System;
using UnityEngine;

public class CollectingController : MonoBehaviour
{
    [SerializeField] private int _coinsCount;

    private int coins;

    public event Action <int> coinsPlus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coins = _coinsCount;
    }

    public void CoinsCollected(int coin)
    {
        coins += coin ;
        coinsPlus?.Invoke(coin);
    }
}
