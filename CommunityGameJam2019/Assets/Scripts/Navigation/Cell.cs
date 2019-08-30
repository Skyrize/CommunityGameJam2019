using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : IHeapItem<Cell>
{
    public bool walkable;
    public Vector3 worldPosition;

    public int gCost;
    public int hCost;

    public int fCost {
        get {
            return gCost + hCost;
        }
    }
    public int x, y;

    public Cell parent;
    int heapIndex;

    public int Distance(Cell other)
    {
        int distX = Mathf.Abs(x - other.x);
        int distY = Mathf.Abs(y - other.y);

        if (distX > distY)
            return 14 * distY + 10 * (distX - distY);
        return 14 * distX + 10 * (distY - distX);
    }

    public Cell(bool _walkable, Vector3 _worldPosition, int _x, int _y)
    {
        walkable = _walkable;
        worldPosition = _worldPosition;
        x = _x;
        y = _y;
    }

    public int HeapIndex
    {
        get {
            return heapIndex;
        }
        set {
            heapIndex = value;
        }
    }

    public int CompareTo(Cell other)
    {
        int compare = fCost.CompareTo(other.fCost);
        if (compare == 0) {
            compare = hCost.CompareTo(other.hCost);
        }
        return -compare;
    }
}
