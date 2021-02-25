
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public Animator animator;

    void OnCollisionEnter(Collision collision )
    {
        Debug.Log("got hit");
         animator.SetTrigger("hit");
        
    }
}
