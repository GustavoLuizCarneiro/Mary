using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class animacaoDoPlayer : MonoBehaviour
{
    public Animator anim_;

    private void Start()
    {
        anim_ = GetComponent<Animator>(); 
    }

    private void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.W))
        {
            anim_.SetBool("mudar", true);
        }
        else
        {
            anim_.SetBool("mudar", false);
        }
        Direita();
        Esquerda();
        Tras();
    }

    void Direita()
    {
        if (UnityEngine.Input.GetKey(KeyCode.D))
        {
            anim_.SetBool("direita", true);
        }
        else
        {
            anim_.SetBool("direita", false);
        }
    }
    void Esquerda()
    {
        if (UnityEngine.Input.GetKey(KeyCode.A))
        {
            anim_.SetBool("esquerda", true);
        }
        else
        {
            anim_.SetBool("esquerda", false);
        }
    }
    void Tras()
    {
        if (UnityEngine.Input.GetKey(KeyCode.S))
        {
            anim_.SetInteger("outros", 1);
        }
        else
        {
            anim_.SetInteger("outros", 0);
        }
    }
}
