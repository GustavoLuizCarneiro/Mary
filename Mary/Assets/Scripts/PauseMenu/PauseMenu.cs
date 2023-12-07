using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject desPause, LoadScene_;

    public void VoltarAoMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void Despausar()
    {
        desPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
