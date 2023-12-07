using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voltar : MonoBehaviour
{
    public GameObject Jogo, Inspecion, jogador;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Jogo.SetActive(true);
            Inspecion.SetActive(false);
            jogador.SetActive(true);
        }
    }
}
