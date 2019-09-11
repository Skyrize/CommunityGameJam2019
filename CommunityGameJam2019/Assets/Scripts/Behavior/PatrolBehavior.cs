using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehavior : StateMachineBehaviour
{
    
    [Header("Attributes")]
    public float speed = 1;

    [Space]
    [Header("References")]
    public GameObject wayPoint = null;
    Vector3 direction;

    private void Start()
    {
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wayPoint = GameObject.FindWithTag("WayPoints").GetComponent<WayPointSystemComponent>().GetNewWaypoint(wayPoint);
        animator.gameObject.GetComponent<PathFollowComponent>().SeekPath(wayPoint.transform.position);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
