using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PathRequestManagerComponent : MonoBehaviour
{
    Queue<PathRequest> requestQueue = new Queue<PathRequest>();
    PathRequest currentRequest;

    static PathRequestManagerComponent instance;
    PathFindingComponent pathfinder;
    bool isProcessing;

    private void Awake()
    {
        instance = this;
        pathfinder = GetComponent<PathFindingComponent>();
    }

    public static void RequestPath(Vector3 start, Vector3 end, Action<Vector3[], bool> callback)
    {
        PathRequest newRequest = new PathRequest(start, end, callback);

        instance.requestQueue.Enqueue(newRequest);
        instance.TryProcessNext();
    }

    void TryProcessNext()
    {
        if (!isProcessing && requestQueue.Count != 0) {
            currentRequest = requestQueue.Dequeue();
            isProcessing = true;
            pathfinder.StartFindPath(currentRequest.start, currentRequest.end);
        }
    }

    public void FinisedProcessingPath(Vector3[] path, bool success)
    {
        currentRequest.callback(path, success);
        isProcessing = false;
        TryProcessNext();
    }

    struct PathRequest
    {
        public Vector3 start;
        public Vector3 end;
        public Action<Vector3[], bool> callback;

        public PathRequest(Vector3 _start, Vector3 _end, Action<Vector3[], bool> _callback)
        {
            start = _start;
            end = _end;
            callback = _callback;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
