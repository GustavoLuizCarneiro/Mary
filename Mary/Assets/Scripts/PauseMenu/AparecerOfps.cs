using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerOfps : MonoBehaviour
{
    public GameObject MostrarFPS;

    private void Update()
    {
        if (ShowFps.fps_ == 1)
        {
            MostrarFPS.SetActive(true);
        }
        else if (ShowFps.fps_ == 0)
        {
            MostrarFPS.SetActive(false);
        }
    }
}
