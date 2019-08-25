using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    [Header("Attributes")]
    public float damages = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        HealthComponent otherHeath = other.GetComponent<HealthComponent>();
        Debug.Log(other.name);
        if (otherHeath)
            other.GetComponent<HealthComponent>().GetDamaged(damages);
        Destroy(gameObject);
    }
}
