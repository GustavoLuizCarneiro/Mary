using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBallroom : MonoBehaviour
{
    public GameObject Sure;

    private void OnTriggerEnter(Collider other)
    {
        Sure.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }

}
