using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    [Header("Attributes")]
    public float damages = 1;
    [Space]
    [Header("Statistics")]
    public float lifeTime = 10;
    private void OnCollisionEnter2D(Collision2D other) {
        HealthComponent otherHeath = other.gameObject.GetComponent<HealthComponent>();
        Debug.Log(other.gameObject.name);
        if (otherHeath)
            other.gameObject.GetComponent<HealthComponent>().GetDamaged(damages);
        Destroy(gameObject);
    }
    
    private void Update()
    {
        if (lifeTime <= 0) {
            Destroy(gameObject);
        } else {
            lifeTime -= Time.deltaTime;
        }
    }
}
