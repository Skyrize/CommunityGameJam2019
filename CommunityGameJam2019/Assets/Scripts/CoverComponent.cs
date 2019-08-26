using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverComponent : MonoBehaviour
{
    [Header("References")]
    public List<GameObject> targets;

    public bool IsFree()
    {
        return targets.Count == 0;
    }

    public bool ContainsTargetWithTag(string tag)
    {
        for (int i = 0; i != targets.Count; i++)
            if (targets[i].tag == tag)
                return true;
        return false;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        targets.Add(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        targets.Remove(other.gameObject);
    }

}
