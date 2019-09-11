using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehavior : StateMachineBehaviour
{
    [Header("Attributes")]
    //public float fleeDuration = 3;
    public float speed = 1;

    [Space]
    [Header("References")]
    public Transform target;

    //[Space]
    //[Header("Statistics")]
    //public float fleeTimer = 3;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if (fleeTimer <= 0) {

        //} else {

        //}
        animator.transform.GetComponent<CharacterMovementComponent>().Move(animator.transform.position - target.position);
        // ;
        // animator.transform.position = Vector2.MoveTowards(, , -speed * Time.deltaTime);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.GetComponent<CharacterMovementComponent>().Move(Vector3.zero);

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
