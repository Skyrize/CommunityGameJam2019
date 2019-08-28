using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFindingComponent : MonoBehaviour
{
    GridSystemComponent grid;

    private void Awake() {
        grid = GetComponent<GridSystemComponent>();
    }
    void FindPath(Vector3 startPos, Vector3 targetPos)
    {
        Cell startCell = grid.WorldToCell(startPos);
        Cell targetCell = grid.WorldToCell(targetPos);
        List<Cell> openSet = new List<Cell>();
        HashSet<Cell> closeSet = new HashSet<Cell>();
        Cell currentCell = null;

        openSet.Add(startCell);
        while (openSet.Count != 0) {
            currentCell = openSet[0];
            for (int i = 1; i != openSet.Count; i++) {
                if (openSet[i].fCost < currentCell.fCost || (openSet[i].fCost == currentCell.fCost && openSet[i].hCost < currentCell.hCost)) {
                    currentCell = openSet[i];
                }
            }

            openSet.Remove(currentCell);
            closeSet.Add(currentCell);

            if (currentCell == targetCell) {

                return;
            }
            
        }
    }
}
