using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeFromTargetComponent : MonoBehaviour
{
    [Header("Statistics")]
    public bool seeTarget = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") == true) {
            Debug.Log("see target");
            seeTarget = true;
            transform.parent.GetComponent<Animator>().SetBool("shouldFlee", true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") == true) {
            Debug.Log("doesn't see target");
            seeTarget = false;
            transform.parent.GetComponent<Animator>().SetBool("shouldFlee", false);
        }
        
    }

}
