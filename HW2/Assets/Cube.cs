using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  [SerializeField] ParticleSystem collectParticle = null;

  public void Update(){
    if (Input.GetKeyDown(KeyCode.Space)){
      Collect();
    }
  }

  public void Collect(){
    //play particle graphics
    collectParticle.Play();
  }
}
