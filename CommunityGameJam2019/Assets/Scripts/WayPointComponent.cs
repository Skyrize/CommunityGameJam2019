using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WayPointComponent : MonoBehaviour
{
    [Header("References")]
    public UnityEvent onWaypointReachedCallback = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D other) {
        Animator anim = other.GetComponent<Animator>();
        PatrolBehavior patrolBehavior = null;

        if (anim)
            patrolBehavior = anim.GetBehaviour<PatrolBehavior>();
        if (patrolBehavior)
            patrolBehavior.StopPatrolling(anim);
            
    }
}
