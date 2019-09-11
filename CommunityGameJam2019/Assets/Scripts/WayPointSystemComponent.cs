using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointSystemComponent : MonoBehaviour
{
    public GameObject GetNewWaypoint(GameObject previous)
    {
        if (transform.childCount == 0) {
            throw new MissingReferenceException("No waypoint in Waypoints " + name);
        } else if (transform.childCount == 1) {
            Debug.Log("hein");
            Debug.Log(transform.GetChild(0).gameObject.name);
            return transform.GetChild(0).gameObject;
        }
        GameObject newWayPoint = transform.GetChild(Random.Range(0, transform.childCount)).gameObject;

        if (!previous)
            return (newWayPoint);
        while (previous == newWayPoint)
            newWayPoint = transform.GetChild(Random.Range(0, transform.childCount)).gameObject;
        return (newWayPoint);
    }
}
