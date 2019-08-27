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

    private void FixedUpdate()
    {
        AnimatorHandler();
    }

    private void AnimatorHandler()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        speed = Mathf.Clamp(direction.magnitude, 0.0f, 1.0f);

		animatorBody.SetFloat("speed", speed);
    }
}
