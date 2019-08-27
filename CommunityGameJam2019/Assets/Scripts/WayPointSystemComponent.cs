using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointSystemComponent : MonoBehaviour
{
    public GameObject GetNewWaypoint(GameObject previous)
    {
        GameObject newWayPoint = transform.GetChild(Random.Range(0, transform.childCount)).gameObject;

        if (!previous)
            return (newWayPoint);
        while (previous == newWayPoint)
            newWayPoint = transform.GetChild(Random.Range(0, transform.childCount)).gameObject;
        return (newWayPoint);
    }
}
