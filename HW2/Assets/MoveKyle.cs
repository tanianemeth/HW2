using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKyle : MonoBehaviour
{
    public Rigidbody kyle;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    void FixedUpdaate()
    {
        if( Input.GetKey("d") )
        {
            kyle.AddForce(sidewaysForce,0,0);
        }
         if( Input.GetKey("a") )
        {
            kyle.AddForce(sidewaysForce,0,0);
        }
    }

}
