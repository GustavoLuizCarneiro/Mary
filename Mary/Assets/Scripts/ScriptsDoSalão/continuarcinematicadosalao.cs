using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continuarcinematicadosalao : MonoBehaviour
{
    public GameObject Salao, Montanhas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Salao.SetActive(false);
            Montanhas.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }       
}
