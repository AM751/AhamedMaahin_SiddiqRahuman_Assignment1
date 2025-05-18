using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private float enemyHit;
    private void OnCollisionEnter(Collision playerCollision)
    {
        var healthController = playerCollision.gameObject.GetComponent<HealthController>();
        if (healthController != null)
        {
            healthController.GetDamage(enemyHit);
            Destroy (gameObject);
        }
    }

}
 