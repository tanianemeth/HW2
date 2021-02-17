using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    Vector3 objPosition;
    float distance;

    public bool canGrab = true;
    public GameObject obj;
    public GameObject parentTemp;
    public bool isHolding = false;

    void Update()
    {
        if(isHolding == true)
        {
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            obj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            obj.transform.SetParent(parentTemp.transform);
        
        if(Input.GetMouseButtonDown(1))
        {
            //throw
        }
        }
        else
        {
            objPosition = obj.transform.position;
            obj.transform.SetParent(null);
            obj.GetComponent<Rigidbody>().useGravity = true;
            obj.transform.position = objPosition;
        }
    }
    // Start is called before the first frame update
    void onMouseDown()
    {
        isHolding = true;
        obj.GetComponent<Rigidbody>().useGravity = false;
        obj.GetComponent<Rigidbody>().detectCollisions = true;
       
       }

    // Update is called once per frame
    void onMouseUp()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.parent = null;
    }
}
