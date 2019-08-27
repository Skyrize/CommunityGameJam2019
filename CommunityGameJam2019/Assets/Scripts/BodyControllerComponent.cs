using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControllerComponent : MonoBehaviour
{
    [Space]
    [Header("Animator")]
    public Animator animatorBody;

    private Vector2 direction;
    private float speed;

    private SpriteRenderer spriteRenderer;
    private ArmControllerComponent armsController;

    private void Start()
    {
        armsController = GameObject.Find("Arms").GetComponent<ArmControllerComponent>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        speed = Mathf.Clamp(direction.magnitude, 0.0f, 1.0f);

        // Used to change the current animation in the animator
        // @see Parameters in Body Animator
        animatorBody.SetFloat("speed", speed);

        spriteRenderer.flipX = GetXFlipDirection();
    }

    /**
     *  We check the finger rotation to determinate the body direction
     */
    private bool GetXFlipDirection()
    {
        if (armsController.direction.x >= 0) {
            return true;
        }

        return false;
    }
}
