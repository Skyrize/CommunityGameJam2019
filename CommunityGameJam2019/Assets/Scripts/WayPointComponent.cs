using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointComponent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Waypoint entered");
        Animator anim =other.GetComponent<Animator>();
        PatrolBehavior patrolBehavior = null;

        if (anim)
            patrolBehavior = anim.GetBehaviour<PatrolBehavior>();
        if (patrolBehavior)
            patrolBehavior.StopPatrolling(anim);
            
    }
}
