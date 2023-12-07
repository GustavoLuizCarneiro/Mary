using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSSHOW : MonoBehaviour
{
    [Header("Contador")]
    [SerializeField] private float taxaDeAtualizacaoDoContador;
    private float quantidadeDeFPS;

    [Header("UI")]
    [SerializeField] private Text textoDoContadorDeFPS;

    private void Start()
    {
        InvokeRepeating(nameof(ContarFPSDoJogo), 0f, taxaDeAtualizacaoDoContador);
    }

    private void ContarFPSDoJogo()
    {
        quantidadeDeFPS = 1f / Time.deltaTime;
        textoDoContadorDeFPS.text = Mathf.Floor(quantidadeDeFPS).ToString() + " FPS";
    }
}
