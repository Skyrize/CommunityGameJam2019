using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PathFindingComponent : MonoBehaviour
{
    PathRequestManagerComponent requestManager;
    GridSystemComponent grid;

    private void Awake()
    {
        grid = GetComponent<GridSystemComponent>();
        requestManager = GetComponent<PathRequestManagerComponent>();
    }

    public void StartFindPath(Vector3 start, Vector3 target)
    {
        StartCoroutine(FindPath(start, target));
    }

    IEnumerator FindPath(GameObject start, GameObject target)
    {
        return FindPath(start.transform.position, target.transform.position);
    }

    IEnumerator FindPath(Vector3 startPos, Vector3 targetPos)
    {
        HashSet<Cell> closeSet = new HashSet<Cell>();
        Heap<Cell> openSet = new Heap<Cell>(grid.MaxSize);
        List<Cell> neighbours;
        Cell startCell = grid.WorldToCell(startPos);
        Cell targetCell = grid.WorldToCell(targetPos);
        Vector3[] waypoints = new Vector3[0];
        bool success = false;

        if (startCell.walkable && targetCell.walkable) {

            Cell currentCell = null;
            int costToNeighbour = 0;

            openSet.Add(startCell);
            while (openSet.Count != 0) {
                currentCell = openSet.RemoveFirst();

                closeSet.Add(currentCell);

                if (currentCell == targetCell) {
                    success = true;
                    break;
                }
                neighbours = grid.GetNeighbours(currentCell);
                foreach (Cell neighbour in neighbours) {
                    if (neighbour.walkable == false || closeSet.Contains(neighbour))
                        continue;
                    costToNeighbour = currentCell.gCost + currentCell.Distance(neighbour);
                    if (costToNeighbour < neighbour.gCost || openSet.Contains(neighbour) == false) {
                        neighbour.gCost = costToNeighbour;
                        neighbour.hCost = neighbour.Distance(targetCell);
                        neighbour.parent = currentCell;
                        if (openSet.Contains(neighbour) == false)
                            openSet.Add(neighbour);
                        else
                            openSet.UpdateItem(neighbour);
                    }
                }
            }
        }
        yield return null;
        if (success == true) {
            waypoints = RetracePath(startCell, targetCell);
        }
        requestManager.FinisedProcessingPath(waypoints, success);
    }

    Vector3[] RetracePath(Cell start, Cell end)
    {
        List<Cell> path = new List<Cell>();
        Vector3[] waypoints;
        Cell currentCell = end;

        while (currentCell != start) {
            path.Add(currentCell);
            currentCell = currentCell.parent;
        }
        waypoints = SimplifyPath(path);
        Array.Reverse(waypoints);
        return waypoints;
    }

    Vector3[] SimplifyPath(List<Cell> path)
    {
        List<Vector3> waypoints = new List<Vector3>();
        Vector2 directionOld = Vector2.zero;

        for (int i = 1; i < path.Count; i++) {
            Vector2 directionNew = new Vector2(path[i - 1].x - path[i].x, path[i - 1].y - path[i].y);

            if (directionNew.Equals(directionOld) == false) {
                waypoints.Add(path[i - 1].worldPosition);
            }
            directionOld = directionNew;
        }
        return waypoints.ToArray();
    }
}
