using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspect : MonoBehaviour
{
    public GameObject Inspecionar, Jogo, jogador, Text;
    public bool Inspecter;

    private void OnTriggerEnter(Collider other)
    {
        Inspecter = true;
        Text.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Inspecter = false;
        Text.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Inspecter == true)
        {
            Inspecionar.SetActive(true);
            Jogo.SetActive(false);
            jogador.SetActive(false);
        }
    }
}
