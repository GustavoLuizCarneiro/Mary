using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcabarCutscene : MonoBehaviour
{
    public GameObject cutsceneObj;
    public GameObject character_;
    public GameObject Trigger;
    public GameObject Coletado, Arma;

    private void Update()
    {
        
        if (startCutscene.animacao == true)
        {
            StartCoroutine(caba());
        }
    }


    IEnumerator caba()
    {
        yield return new WaitForSeconds(7);
        cutsceneObj.SetActive(false);
        character_.SetActive(true);
        Trigger.SetActive(false);
        Arma.SetActive(false);
        Coletado.SetActive(true);
        StartCoroutine(Missao());
    }

    IEnumerator Missao()
    {
        yield return new WaitForSeconds(2.5f);
        Coletado.SetActive(false);
    }
}
