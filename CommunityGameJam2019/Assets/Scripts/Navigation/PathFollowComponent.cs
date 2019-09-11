using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PathFollowComponent : MonoBehaviour
{
    public UnityEvent callback = new UnityEvent();
    Vector3[] path;
    int targetIndex;

    public void SeekPath(Vector3 position)
    {
        PathRequestManagerComponent.RequestPath(transform.position, position, OnPathFound);
    }

    public void OnPathFound(Vector3[] newPath, bool success)
    {
        if (success) {
            path = newPath;
            targetIndex = 0;
            StopCoroutine("FollowPath");
            if (path.Length == 0) {
                Finish();
            } else {
                StartCoroutine("FollowPath");
            }
        }
    }
    void Finish()
    {
        callback.Invoke();
        GetComponent<CharacterMovementComponent>().Move(Vector3.zero);
    }

    IEnumerator FollowPath()
    {
        Vector3 currentWaypoint = path[0];
        Vector3 direction;

        while (true) {
            if (Vector3.Distance(transform.position, currentWaypoint) <= 0.1f) {
                targetIndex++;
                if (targetIndex >= path.Length) {
                    Finish();
                    yield break;
                }
                currentWaypoint = path[targetIndex];
            }
            direction = currentWaypoint - transform.position;
            direction.Normalize();
            GetComponent<CharacterMovementComponent>().Move(direction);
            // transform.position = Vector3.MoveTowards(, , GetComponent<CharacterMovementComponent>().maxSpeed * Time.deltaTime);
            yield return null;
        }
    }

    public bool DebugMode = true;

    private void OnDrawGizmos()
    {
        if (DebugMode && path != null) {
            for (int i = targetIndex; i != path.Length; i++) {
                Gizmos.color = Color.black;
                Gizmos.DrawCube(path[i], new Vector3(0.2f, 0.2f));
                if (i == targetIndex)
                    Gizmos.DrawLine(transform.position, path[i]);
                else
                    Gizmos.DrawLine(path[i-1], path[i]);

            }
        }
    }
}
