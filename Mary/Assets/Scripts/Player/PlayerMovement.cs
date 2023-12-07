using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Frente();
    }

    void Frente()
    {
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetInteger("Transition", 2);
        }
        else
        {
            anim.SetInteger("Transition", 0);
        }
    }
}