using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class night_loader : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;
  //triggering level change with button



    void Update()
    {
      if(Input.GetMouseButtonDown(0)){

        load_night();
      }

    }
    public void load_night(){
        transition.SetTrigger("night_time");

    }


}
