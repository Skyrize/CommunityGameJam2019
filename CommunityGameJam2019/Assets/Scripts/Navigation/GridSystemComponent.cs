using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemComponent : MonoBehaviour
{
    public LayerMask unwalkableMask;
    public Vector3 gridWorldSize = Vector2.one;
    public float cellRadius = 0.5f;

    Cell[,] grid;

    float cellDiameter;
    int gridSizeX;
    int gridSizeY;

    private void Start()
    {
        cellDiameter = cellRadius * 2;
        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / cellDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.y / cellDiameter);
        CreateGrid();
    }

    void CreateGrid()
    {
        grid = new Cell[gridSizeX, gridSizeY];
        Vector3 startPosition = transform.position - Vector3.right * gridWorldSize.x / 2 - Vector3.up * gridWorldSize.y / 2;

        for (int x = 0; x < gridSizeX; x++) {
            for (int y = 0; y < gridSizeY; y++) {
                Vector3 newPosition = startPosition + Vector3.right * (x * cellDiameter + cellRadius) + Vector3.up * (y * cellDiameter + cellRadius);
                newPosition.z = 0;
                bool walkable = !Physics2D.OverlapCircle(newPosition, cellRadius, unwalkableMask);
                grid[x, y] = new Cell(walkable, newPosition, x, y);
            }
        }
    }

    public List<Cell> GetNeighbours(Cell cell)
    {
        List<Cell> neighbours = new List<Cell>();
        int checkX, checkY;

        for (int x = -1; x != 2; x++) {
            for (int y = -1; y != 2; y++) {
                if (x == 0 && y == 0) {
                    continue;
                }
                checkX = cell.x + x;
                checkY = cell.y + y;
                if (checkX >= 0 && checkX < gridSizeX && checkY >= 0 && checkY < gridSizeY) {
                    neighbours.Add(grid[checkX, checkY]),
                }
            }
        }
        return neighbours;
    }

    public Cell WorldToCell(Vector3 targetPosition)
    {
        Vector3 position = targetPosition - transform.position + new Vector3(gridWorldSize.x / 2,  gridWorldSize.y / 2, 0);
        float percentX = position.x / gridWorldSize.x;
        float percentY = position.y / gridWorldSize.y;
        int x;
        int y;

        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);
        x = Mathf.RoundToInt((gridSizeX - 1) * percentX);
        y = Mathf.RoundToInt((gridSizeY - 1) * percentY);
        return grid[x,y];
    }

    public Cell WorldToCell(GameObject target)
    {
        Vector3 position = target.transform.position - transform.position + new Vector3(gridWorldSize.x / 2,  gridWorldSize.y / 2, 0);
        float percentX = position.x / gridWorldSize.x;
        float percentY = position.y / gridWorldSize.y;
        int x;
        int y;

        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);
        x = Mathf.RoundToInt((gridSizeX - 1) * percentX);
        y = Mathf.RoundToInt((gridSizeY - 1) * percentY);
        return grid[x,y];
    }

    public GameObject Player;
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, gridWorldSize);

        if (grid != null) {
            Cell playerCell = WorldToCell(Player);
            foreach (Cell cell in grid) {
                Gizmos.color = cell.walkable ? Color.blue : Color.red;
                if (cell == playerCell)
                    Gizmos.color = Color.green;
            }
        }
    }
}
