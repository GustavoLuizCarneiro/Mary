using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;

public class CriarCena : MonoBehaviour
{
     public TextMeshProUGUI textoTMP;
    public int IndexAtual;
    [SerializeField]
    public List<minhaCena> meuDialogo;
    [Serializable]
    public class minhaCena
    {
        public bool ProsseguirCena;
        [HideInInspector]
        public float tempo;
        public float tempoTextoEmTela;
        public string texto;
        public string animacaoTocar;
        public bool animacaoAcabou;
    }
    

    // Update is called once per frame
    void Update()
    {
        //VERIFICA SE A CENA ATUAL JÁ PODE SER INICIADA (ATIVAR BOOL POR BOXTRIGGER)
        //SE PUDER RODA ELA E AS PRÓXIMAS FALAS QUE ESTIVEREM TRUE;
        //SÓ PARA NA PRÓXIMA QUE INICIARCENA FOR FALSE
        if (meuDialogo[IndexAtual].ProsseguirCena==true)
        {
            textoTMP.text = meuDialogo[IndexAtual].texto;
            meuDialogo[IndexAtual].tempo+=Time.deltaTime;

            if (meuDialogo[IndexAtual].tempo>meuDialogo[IndexAtual].tempoTextoEmTela 
            && meuDialogo[IndexAtual].animacaoAcabou==true && IndexAtual<meuDialogo.Count-1)
            {
                // se ja esperou o tempo acabar e a animacao concluir:
                IndexAtual++;
            }
            else if (meuDialogo[IndexAtual].tempo>meuDialogo[IndexAtual].tempoTextoEmTela 
            && IndexAtual==meuDialogo.Count-1)
            {
                
                textoTMP.text ="";
            }
           
        }
        else if (meuDialogo[IndexAtual].ProsseguirCena==false )
        {
            textoTMP.text ="";
        }
    }
}
