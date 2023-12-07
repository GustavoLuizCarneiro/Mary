using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public  GameObject cutsceneObj;
    public  GameObject character_;
    public static bool animacao;

    private void Start()
    {
        animacao = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        cutsceneObj.SetActive(true);
        character_.SetActive(false);
        animacao = true;
    }
}
