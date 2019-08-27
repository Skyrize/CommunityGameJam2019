using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehavior : StateMachineBehaviour
{
    [Header("Attributes")]
    public float fleeingDistance = 2;
    public float patrolWaiting = 3;

    [Space]
    [Header("Attributes")]
    
    [Space]
    [Header("Statistics")]
    public float waitingTimer = 0;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       waitingTimer = patrolWaiting;
    }

       //animator.SetBool("shouldPatrol", true);

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // if (Vector2.Distance(target.position, animator.transform.position) <=  fleeingDistance) {
        // }
        if (waitingTimer <= 0) {
            animator.SetBool("shouldPatrol", true);
        } else {
            waitingTimer -= Time.deltaTime;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
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
