
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public Animator animator;

    void OnCollisionEnter(Collision collision )
    {
        Debug.Log("gor hit");
         animator.SetTrigger("Hit");
    }
}
