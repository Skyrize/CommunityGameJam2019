using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesComponent : MonoBehaviour
{
    private Transform EnemieTransform;
    public Vector2 direction;

    private SpriteRenderer enemieSprite;

    void Start()
    {
        EnemieTransform = GameObject.Find("Character").GetComponent<Transform>();
        enemieSprite = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    	direction = new Vector2(EnemieTransform.position.x - transform.position.x, EnemieTransform.position.y - transform.position.y);
        enemieSprite.flipX = GetDirectionEnemi();
    }

    /**
     * Get the X direction of enemi compared to the center of current player
     */
    private bool GetDirectionEnemi()
    {
        if (direction.x >= 0) {
            return true;
        }

        return false;
    }
}
