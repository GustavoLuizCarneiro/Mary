using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua2 : MonoBehaviour
{
    public static bool DesligarAgua = false;
    public GameObject Agua;

    private void Update()
    {
        if (DesligarAgua == true && Agua == true)
        {
            Agua.SetActive(false);
            StartCoroutine(Desligar());
        }
    }
    IEnumerator Desligar()
    {
        yield return new WaitForSeconds(0.1f);
        DesligarAgua = false;
    }
}
