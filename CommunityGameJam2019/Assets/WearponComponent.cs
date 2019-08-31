using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearponComponent : MonoBehaviour
{
    private Transform playerTransform;
    public Vector2 direction;

    private SpriteRenderer gunSpriteRenderer;

    void Start()
    {
        playerTransform = GameObject.Find("Character").GetComponent<Transform>();
        gunSpriteRenderer = GameObject.Find("Wearpon").GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        FaceToPlayer();
        gunSpriteRenderer.flipY = GetDirectionGun();
    }

    void FaceToPlayer()
    {
        direction = new Vector2(playerTransform.position.x - transform.position.x, playerTransform.position.y - transform.position.y);
        transform.right = direction;
    }

    /**
     * Get the X direction of player compared to the center of current wearpon
     */
    private bool GetDirectionGun()
    {
        if (direction.x >= 0) {
            return false;
        }

        return true;
    }
}
