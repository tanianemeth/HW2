
using UnityEngine;

public class MoveKyle : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 50f;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey("d"))
        {
            Debug.Log("d");
            rb.AddForce(sidewaysForce,0,0);
        }
        if (Input.GetKey("a"))
        {
             Debug.Log("a");
            rb.AddForce(-sidewaysForce,0,0);
        }
    }
}
