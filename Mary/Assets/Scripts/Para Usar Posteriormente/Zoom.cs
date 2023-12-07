using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public Camera cam;
    public float defaultFov = 75f;
    public float zoomSpeed = 10f;
    public float minFov = 25f;
    public float maxFov = 55f;
    private void Update()
    {
        HandleZoom();
        if (ChooseObject.Camera_ == false)
        {
            cam.fieldOfView = 75f;
        }
    }

    private void HandleZoom()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        cam.fieldOfView -= scrollInput * zoomSpeed;
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minFov, maxFov);
    }
}
