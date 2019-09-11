using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementComponent : MonoBehaviour
{
    [Header("Attributes")]
    public float maxSpeed = 5;
    [Space]
    [Header("References")]
    public Rigidbody2D rb;

    [Space]
    [Header("Statistics")]
    public Vector2 direction;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Move(Vector2 newDirection)
    {
        direction = newDirection;
        speed = Mathf.Clamp(direction.magnitude, 0.0f, 1.0f);
        direction.Normalize();
        rb.velocity = direction * speed * maxSpeed;
    }

    private void Update() {
        if (direction == Vector2.zero && rb.velocity != Vector2.zero)
            Move(Vector2.zero);
    }

}
