using System;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float fullhealth;

    private float _health;

    // Health Update Event:
    public event Action<float, float, float> OnHealthUpdated; //Damage taken, Full health, Current health.



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _health = fullhealth;
    }

    public void GetDamage(float damage)
    {
        _health -= damage;
        OnHealthUpdated?.Invoke(damage, fullhealth, _health);
    }

}
