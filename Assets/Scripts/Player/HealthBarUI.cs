using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private HealthController healthController;
    [SerializeField] private Image healthBarImage;

    void OnEnable()
    {
        healthController.OnHealthUpdated += OnHealthUpdated;
    }

    void OnDisable()
    {
        healthController.OnHealthUpdated -= OnHealthUpdated;
    }
    private void OnHealthUpdated(float damage, float fullHealth, float currentHealth)
    {
        healthBarImage.fillAmount = currentHealth / fullHealth;
    }

}
