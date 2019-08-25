using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
    [Header("Attributes")]
    public float fireRate = 1;
    public float fireSpeed = 1;

    private float fireCooldown = 0;
    [Space]
    [Header("References")]

    public Transform firePoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Fire()
    {
        if (fireCooldown <= 0) {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            fireCooldown = fireRate;
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * fireSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fireCooldown > 0)
            fireCooldown -= Time.deltaTime;
    }
}
