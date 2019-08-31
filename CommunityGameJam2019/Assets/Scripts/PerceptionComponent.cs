using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class PerceptionEvent : UnityEvent<bool, GameObject>
{
}

public class PerceptionComponent : MonoBehaviour
{
    [Header("Parameters")]
    public string[] tags;
    public PerceptionEvent onPerceptionCallback = new PerceptionEvent();

    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach (string tag in tags) {
            if (other.CompareTag(tag) == true) {
                onPerceptionCallback.Invoke(true, other.gameObject);
                break;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        foreach (string tag in tags) {
            if (other.CompareTag(tag) == true) {
                onPerceptionCallback.Invoke(false, other.gameObject);
                break;
            }
        }
    }

}
