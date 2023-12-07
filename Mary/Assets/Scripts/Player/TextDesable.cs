using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TextDesable : MonoBehaviour
{

    public GameObject textoCapituloUm;

    void Update()
    {
        StartCoroutine(Sumir());
    }
    IEnumerator Sumir()
    {
        yield return new WaitForSeconds(7);
        Destroy(textoCapituloUm);
    }
}
