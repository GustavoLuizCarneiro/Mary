using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    public bool LigarAgua;
    public GameObject Aguaa, Textow;

    private void Start()
    {
        LigarAgua = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        LigarAgua = true;
        Textow.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        LigarAgua = false;
        Textow.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && LigarAgua == true)
        {
            Aguaa.SetActive(true);
        } 
        if(Input.GetKeyUp(KeyCode.E) && LigarAgua == true)
        {
            StartCoroutine(Desligar());
        }
    }

    IEnumerator Desligar()
    {
        yield return new WaitForSeconds(0.1f);
        Agua2.DesligarAgua = true;
    }
}
