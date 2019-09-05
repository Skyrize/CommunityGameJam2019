using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SanityComponent : MonoBehaviour
{
    [Header("Attributes")]
    public float minSanity = 25;
    public float maxSanity = 100;
    public UnityEvent insaneEvent = new UnityEvent();
    public UnityEvent saneEvent = new UnityEvent();

    [Space]
    [Header("Statistics")]

    public float sanity = 100;
    public bool isSane
    {
        get {
            return sanity > minSanity;
        }
    }

    public void GetHealed(float amount)
    {
        bool wasSane = isSane;

        sanity = Mathf.Min(sanity + amount, maxSanity);
        if (isSane && !wasSane) {
            saneEvent.Invoke();
        }
    }

    public void GetDamaged(float amount)
    {
        bool wasSane = isSane;

        sanity = Mathf.Max(sanity - amount, 0.0f);
        if (!isSane && wasSane) {
            insaneEvent.Invoke();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sanity = maxSanity;
    }
}
