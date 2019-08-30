using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{
    [Space]
    [Header("Animator")]
    public Animator animator;

    private Vector2 direction;
    private float speed;

    private void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        speed = Mathf.Clamp(direction.magnitude, 0.0f, 1.0f);

        // Used to change the current animation in the animator
        // @see Parameters in Body Animator
        animator.SetFloat("speed", speed);
    }
}
