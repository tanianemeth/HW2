
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public Animation swing;
    void OnCollisionEnter()
    {
         swing.Play();
    }
}
