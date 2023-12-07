using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AbrirMenu : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true;

            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
        }
    }
}
