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
        characterController = GetComponentInChildren<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }


    void Update()
    {
        var forward = Input.GetAxis("Horizontal") * speed;
        var sideways = Input.GetAxis("Vertical") * speed;

        characterController.SimpleMove(new Vector3(forward, 0,sideways));
        
        if(!characterController.isGrounded)
        {
            characterController.SimpleMove(new Vector3(0,-8,0));
        }
    
        if (Input.GetKey("q"))
        {
            Debug.Log("q");
            animator.SetTrigger("shoot");
            
        }
        if(forward > 0.01 || sideways > 0.01 )
        {
             animator.ResetTrigger("shoot");
        }
  
        animator.SetFloat("speed",characterController.velocity.magnitude);
    }
}
