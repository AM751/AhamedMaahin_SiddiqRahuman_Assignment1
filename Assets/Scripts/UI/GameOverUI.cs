using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private HealthController healthBarUI;
    [SerializeField] private Canvas gameOverCanvas;


    void OnEnable()
    {
        healthBarUI.OnHealthUpdated += GameOverCanvas;
    }

    void OnDisable()
    {
        healthBarUI.OnHealthUpdated -= GameOverCanvas;
    }

    private void GameOverCanvas(float damage, float fullHealth, float currentHealth)
    {
        if (healthBarUI != null && currentHealth <= 0)
        {
            gameOverCanvas.enabled = true;
            Time.timeScale = 0f;
        }
    }
}
