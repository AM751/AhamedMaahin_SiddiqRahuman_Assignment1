using UnityEngine;

public class Coin_Collect : MonoBehaviour
{

    private int _coinsCollected = 1;

    private void OnCollisionEnter(Collision collision)
    {
        var coinsCollector = collision.gameObject.GetComponent<CollectingController>();
        if (coinsCollector != null)
        {
          coinsCollector.CoinsCollected(_coinsCollected);
          Destroy(gameObject);
        }
    }
}
