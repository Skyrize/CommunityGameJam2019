using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthComponent : MonoBehaviour
{
    [Header("Attributes")]
    public float maxHealth = 100;
    public UnityEvent dieEvent = new UnityEvent();

    [Space]
    [Header("Statistics")]

    public float health = 100;
    bool isAlive = true;

    public void GetHealed(float amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
    }

    public void GetDamaged(float amount)
    {
        health = Mathf.Max(health - amount, 0);
        if (health <= 0) {
            isAlive = false;
            dieEvent.Invoke();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }
}
