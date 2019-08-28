using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public bool walkable;
    public Vector3 worldPosition;

    public Cell(bool _walkable, Vector3 _worldPosition)
    {
        walkable = _walkable;
        worldPosition = _worldPosition;
    }
}
