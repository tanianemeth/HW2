
// pick up and drag tutorial: https://www.youtube.com/watch?v=0yHBDZHLRbQ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    private Vector3 offset;

    private float mouseCoordinates;

    void OnMouseDown()
    {
        mouseCoordinates = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }
   

    private Vector3 GetMouseWorldPosition()
    {
        //pixel coord
        Vector3 mousePoint = Input.mousePosition;

        //xyz
        mousePoint.z = mouseCoordinates;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
     void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + offset;
    }
}
