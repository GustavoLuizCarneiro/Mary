using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreYouSureYouWantToLeave : MonoBehaviour
{
    [SerializeField] public GameObject Aysywtl;
    [SerializeField] public GameObject Trigger;
    [SerializeField] public GameObject CinematicaCelular;
    [SerializeField] public GameObject Resto1, Resto2, texto_, Resto3;
    //------------------------------------------------------
    //Se apertar "Sim"
    public void Yes()
    {
        CinematicaCelular.SetActive(true);   
        Resto1.SetActive(false);
        Resto2.SetActive(false);
        Resto3.SetActive(false);
        StartCoroutine(Sair());

    }
//------------------------------------------------------
//Se apertar "Não"
    public void No()
    {
        Aysywtl.SetActive(false);
        Trigger.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        StartCoroutine(Trigger_());
    }
    IEnumerator Trigger_()
    {
        yield return new WaitForSeconds(2);
        Trigger.SetActive(true);

    }
    IEnumerator Sair()
    {
        yield return new WaitForSeconds(7f);
        texto_.SetActive(true);
        yield return new WaitForSeconds(13f);
        SceneManager.LoadScene(0);
    }

}
