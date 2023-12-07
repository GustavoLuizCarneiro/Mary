using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject PainelMenu, PainelOpcoes, PainelIntrucoes, LogoMary, ScreenLoad, SemiPlay, ImagePaper, ButtonContinue;
    public Slider volumeSom, volumeSomGlobal;
    public AudioSource soundMaster, soundGlobal;

    private void Update()
    {
        soundMaster.GetComponent<AudioSource>().volume = volumeSom.value;
        soundGlobal.GetComponent<AudioSource>().volume = volumeSomGlobal.value;
    }
    private void Start()
    {
        volumeSom.value = 0.5f;
        volumeSomGlobal.value = 0.5f;
    }

    public void Play()
    {
        ScreenLoad.SetActive(true);
        StartCoroutine(GameStart());
        ImagePaper.SetActive(false);
        ButtonContinue.SetActive(false);
    }

    public void Jogar()
    {

        SemiPlay.SetActive(true);
        PainelMenu.SetActive(false);
        LogoMary.SetActive(false);
    }

    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }

    public void AbrirOpcoes()
    {
        PainelMenu.SetActive(false);
        PainelOpcoes.SetActive(true);
        LogoMary.SetActive(false);
    }

    public void FecharOpcoes()
    {
        PainelOpcoes.SetActive(false);
        PainelMenu.SetActive(true);
        LogoMary.SetActive(true);
    }

    public void AbrirInstrucoes()
    {
        PainelMenu.SetActive(false);
        PainelIntrucoes.SetActive(true);
        LogoMary.SetActive(false);
    }

    public void FecharInstrucoes()
    {
        PainelMenu.SetActive(true);
        PainelIntrucoes.SetActive(false);
        LogoMary.SetActive(true);
    }

    public void JogoSair()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }

    public void Low()
    {
        QualitySettings.SetQualityLevel(0, true);
    }
    public void Medium()
    {
        QualitySettings.SetQualityLevel(1, true);
    }
    public void High()
    {
        QualitySettings.SetQualityLevel(2, true);
    }
    public void Ultra()
    {
        QualitySettings.SetQualityLevel(3, true);
    }
}
