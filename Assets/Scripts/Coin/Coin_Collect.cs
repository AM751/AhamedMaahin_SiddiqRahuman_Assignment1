using UnityEngine;

public class Coin_Collect : MonoBehaviour
{

    [SerializeField] public int coinsCollected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision == null)
    //    {

    //    }
    //}
}
