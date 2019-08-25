using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerComponent : MonoBehaviour
{
    [Header("References")]
    public GameObject gun;

    public void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            gun.GetComponent<GunComponent>().Fire();
        }
    }
}
