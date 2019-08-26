using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeingBehavior : StateMachineBehaviour
{
    [Header("Attributes")]
    public float speed = 1;
    public float fleeingTime = 1;

    [Space]
    [Header("References")]
    public Transform target;
    [Space]
    [Header("Statistics")]
    public float fleeingTimer = 0;

    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       target = GameObject.FindGameObjectWithTag("Player").transform;
       fleeingTimer = fleeingTime;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (fleeingTimer <= 0) {
            animator.SetBool("shouldRun", false);
        } else {
            fleeingTimer -= Time.deltaTime;
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, target.position, -speed * Time.deltaTime);
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
