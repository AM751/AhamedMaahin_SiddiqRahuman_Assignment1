using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private HealthController healthBarUI;
    [SerializeField] private Canvas gameOverCanvas;

    void Start ()
    {
        gameOverCanvas.enabled = false;
    }
    void OnEnable()
    {
        healthBarUI.OnHealthUpdated += GameOverCanvas;
    }

    void OnDisable()
    {
        healthBarUI.OnHealthUpdated -= GameOverCanvas;
    }

    public void PlayAgain ()
    {
        SceneManager.LoadScene(1);
    }
    public void GameOverCanvas(float damage, float fullHealth, float currentHealth)
    {
        if (healthBarUI != null && currentHealth <= 0)
        {
            gameOverCanvas.enabled = true;
            Time.timeScale = 0f;
        }
    }
}
