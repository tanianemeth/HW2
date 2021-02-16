using UnityEngine;

public class CameraManager : MonoBehaviour {
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    void Update()
    {


        if (Input.GetKey("c"))
        {
            Debug.Log("c");
            ShowFirstPersonView();
        }
        if (Input.GetKey("v"))
        {
            Debug.Log("v");
           ShowOverheadView();
        }
    }
}