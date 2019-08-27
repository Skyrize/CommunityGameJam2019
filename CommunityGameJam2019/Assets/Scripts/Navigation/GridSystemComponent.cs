using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemComponent : MonoBehaviour
{
    
    [Header("Attributes")]
    public int columns = 2;
    public int rows = 2;
    public Vector2 cellScale = new Vector2(1,1);
    [Space]
    [Header("Attributes")]
    public GameObject cellPrefab;

    private void OnValidate()
    {
        float sizeX = cellPrefab.GetComponent<BoxCollider2D>().size.x;
        float sizeY = cellPrefab.GetComponent<BoxCollider2D>().size.y;
        Vector3 position;
        GameObject cell = null;

        while (transform.childCount != 0)
            Destroy(transform.GetChild(0));
        for (int y = 0; y != columns; y++) {
            for (int x = 0; x != rows; x++) {
                position = new Vector3(x * sizeX * cellScale.x, y * sizeY * cellScale.y);
                cell = Instantiate(cellPrefab, position, transform.rotation, transform);
                cell.transform.localScale = cellScale;
            }
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
