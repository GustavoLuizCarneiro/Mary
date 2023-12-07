using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabanaestranha : MonoBehaviour
{
    public GameObject textoDaCabana;

    private void OnTriggerEnter(Collider other)
    {

        textoDaCabana.SetActive(true);
        StartCoroutine(Texto());
    }

    IEnumerator Texto()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
        Destroy(textoDaCabana.gameObject);
    }

}
