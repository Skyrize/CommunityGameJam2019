using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenBehaviorComponent : MonoBehaviour
{

    public void OnWaypointJoined()
    {
        GetComponent<Animator>().SetBool("shouldPatrol", false);
    }
    public void OnSeePlayer(bool isInSight, GameObject Player)
    {
        Debug.Log("seeplayer");
        GetComponent<Animator>().SetBool("seePlayer", isInSight);
    }
    
    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.CompareTag("Citizen")) {
            Debug.Log("Collide");
            CharacterMovementComponent movement = GetComponent<CharacterMovementComponent>();
            Vector2 position = new Vector2(transform.position.x, transform.position.y);
            Quaternion rotation = Quaternion.Euler(0,0,10);
            Vector2 direction = other.contacts[0].point - position;
            float sin = Mathf.Sin(20 * Mathf.Deg2Rad);
            float cos = Mathf.Cos(20 * Mathf.Deg2Rad);
         
            float tx = direction.x;
            float ty = direction.y;
            direction.x = (cos * tx) - (sin * ty);
            direction.y = (sin * tx) + (cos * ty);

            movement.Move(direction);
        }
    }

}
