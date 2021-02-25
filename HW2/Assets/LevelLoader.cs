﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;
  //triggering level change with button



    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space)){
        LoadNextLevel();
      }

    }
    public void LoadNextLevel(){
      StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    //coroutine
    IEnumerator LoadLevel(int levelIndex){
      //play animation
      transition.SetTrigger("Start");

      //wait
      yield return new WaitForSeconds(transitionTime);

      //load scene
      SceneManager.LoadScene(levelIndex);
    }
}
