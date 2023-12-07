using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirInventario : MonoBehaviour
{
    public GameObject Inventario;
    bool switch_;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            switch_ = !switch_;
        }
        if(switch_ == true)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Inventario.SetActive(true);
        }
        else
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Inventario.SetActive(false);
        }

    }
}
