using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
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
    public Cell(bool _walkable, Vector3 _worldPosition, int _x, int _y)
    {
        walkable = _walkable;
        worldPosition = _worldPosition;
        x = _x;
        y = _y;
    }
}
