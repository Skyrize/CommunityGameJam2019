using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControllerComponent : MonoBehaviour
{
    [Header("Statistics")]
    private Vector3 mousePosition;
    public Vector2 direction;

    private SpriteRenderer gunSpriteRenderer;

    private void Start()
    {
        gunSpriteRenderer = GameObject.Find("Gun").GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        FaceMouse();

        gunSpriteRenderer.flipY = GetDirectionFinger();
    }

    void FaceMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.right = direction;
    }

    /**
     * Get the X direction of mouse compared to the center of current player
     */
    private bool GetDirectionFinger()
    {
        if (direction.x >= 0) {
            return false;
        }

        return true;
    }
}
