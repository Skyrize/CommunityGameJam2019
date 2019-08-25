using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControllerComponent : MonoBehaviour
{
    [Header("Statistics")]
    private Vector3 mousePosition;
    public Vector2 direction;
    void FaceMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.right = direction;
    }
    // Update is called once per frame
    void Update()
    {
        FaceMouse();
    }
}
