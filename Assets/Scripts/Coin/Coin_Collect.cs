using UnityEngine;

public class Coin_Collect : MonoBehaviour
{

    [SerializeField] private int _coinsCollected;

   
    private void OnCollisionEnter (Collision collision)
    {
        var coinsCollector = collision.gameObject.GetComponent<CollectingController>();
        if (coinsCollector != null)
        {
           Debug.Log ("Coin");
          coinsCollector.CoinsCollected(_coinsCollected);
          Destroy(gameObject);
        }

    }
}
