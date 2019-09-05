using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsControllerComponent : MonoBehaviour
{
    [Space]
    [Header("Animator")]
    public Animator animatorLegs;

    private Vector2 direction;
    private float speed;
    private SpriteRenderer spriteRenderer;
    private float horizontalMove;

    private CharacterMovementComponent movement;

    private void Awake()
    {
        horizontalMove = 0f;
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        movement = transform.parent.GetComponent<CharacterMovementComponent>();
    }

    private void FixedUpdate()
    {
        speed = Mathf.Clamp(movement.direction.magnitude, 0.0f, 1.0f);

        // Used to change the current animation in the animator
        // @see Parameters in Body Animator
        animatorLegs.SetFloat("speed", speed);

        spriteRenderer.flipX = GetXFlipDirection();
    }

    /**
     *  Get the direction of the player
     *  If no direction is selected, we return the current direction
     *  true -> right & false -> left
     */
    private bool GetXFlipDirection()
    {
        if (horizontalMove > 0) {
            return true;
        } else if (horizontalMove < 0) {
            return false;
        }

        return spriteRenderer.flipX;
    }
}
