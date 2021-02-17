using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController characterController;
    private Animator animator;
    public float speed = 1f;
   
    void Awake()
    {
        //better way of getting component, this way object can spawm with all the right components. 
        characterController = GetComponentInChildren<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }


    void Update()
    {
        // w,s or updown. made for a controller joystick, think forward on the joystick
        var forward = Input.GetAxis("Horizontal") * speed; 
        //a , d or right left. this is the x axis on the joystick 
        var sideways = Input.GetAxis("Vertical") * speed;

        //simple move
        characterController.SimpleMove(new Vector3(forward,3,sideways));
        
    // our gravity for our player
    // https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
        if(!characterController.isGrounded)
        {
            characterController.SimpleMove(new Vector3(0,-9,0));
        }
    
    // set trigger activated the animation
        if (Input.GetKey("q"))
        {
            Debug.Log("q");
            animator.SetTrigger("shoot");
            
        }
        //if character moves, reset the punch trigger for the animation
        if(forward > 0.01 || sideways > 0.01 )
        {
             animator.ResetTrigger("shoot");
        }

        //how to set a wait time, like after 2 seconds reset trigger
  
        animator.SetFloat("speed",characterController.velocity.magnitude);
    }
}
