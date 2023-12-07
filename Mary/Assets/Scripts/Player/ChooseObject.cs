using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChooseObject : MonoBehaviour
{
    [Header("OBJETOS")]

    public GameObject LuzNegra, TextLuzNegra, CamLayout, CamText, ZoomActivate, TextoCancelar1, TextoCancelar2, LayoutInteiro;

    [Header("BOOLS, IGNORAR")]

    public static bool LuzNegra_, Camera_;

    private void Start()
    {
        LuzNegra_ = false;
        LayoutInteiro.SetActive(false);
        StartCoroutine(AparecerLayout());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CamLayout.SetActive(false);
            CamText.SetActive(false);
            LuzNegra_ = !LuzNegra_;
            TextLuzNegra.SetActive(true);
            StartCoroutine(TextoLuzNegra());
        }
        if(LuzNegra_ == false)
        {
            LuzNegra.SetActive(false);
            TextoCancelar1.SetActive(false);

        }
        if(LuzNegra_ != false)
        {
            LuzNegra.SetActive(true);
            TextoCancelar1.SetActive(true);
        }
        //Camera();
    }

    void Camera()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Camera_ = !Camera_;
            LuzNegra.SetActive(false);
            TextLuzNegra.SetActive(false);
            CamLayout.SetActive(true);
            CamText.SetActive(true);
            StartCoroutine(TextoCamera());

        }
        if (Camera_ == false)
        {
            CamLayout.SetActive(false);
            ZoomActivate.SetActive(false);
            TextoCancelar2.SetActive(false);
        }
        if (Camera_ != false)
        {
            CamLayout.SetActive(true);
            ZoomActivate.SetActive(true);
            TextoCancelar2.SetActive(true);
        }

    }

    IEnumerator TextoLuzNegra()
    {
        yield return new WaitForSeconds(2f);
        TextLuzNegra.SetActive(false);
    }
    IEnumerator TextoCamera()
    {
        yield return new WaitForSeconds(2f);
        CamText.SetActive(false);
    }
    
    IEnumerator AparecerLayout()
    {
        yield return new WaitForSeconds(6);
        LayoutInteiro.SetActive(true);
    }


}
