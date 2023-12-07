using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transicao : MonoBehaviour
{
    public Transform mycam;
    public Transform posicaoFixa;

    public Animator anim;
    public string blendAtual;

    public AnimationCurve movementCurve;
    [HideInInspector]
    public float tempo;
    [HideInInspector]
    public float tempo2;
    bool deitado;
    string animacaoTocando;
    

     void MoveSmooth(float target, string valorMudar)
    {
        if (target!=0 && target>0 && movementCurve.Evaluate(tempo)<target)
        {
            tempo += Time.deltaTime;
        }
        if (target!=0 && target<0 && movementCurve.Evaluate(tempo)>target)
        {
            tempo -= Time.deltaTime;
        }
        if (target==0)
        {
            //tempo=2f;
            if (movementCurve.Evaluate(tempo)<-0.01f)
            {
                tempo += Time.deltaTime;
            }
            else if (movementCurve.Evaluate(tempo)>0.01f)
            {
                tempo -= Time.deltaTime;
            }
        }
        //Debug.Log(movementCurve.Evaluate(tempo));
        anim.SetFloat(valorMudar,movementCurve.Evaluate(tempo));
         
    }
    void MoveSmooth2(float target, string valorMudar)
    {
        if (target!=0 && target>0 && movementCurve.Evaluate(tempo2)<target)
        {
            tempo2 += Time.deltaTime;
        }
        if (target!=0 && target<0 && movementCurve.Evaluate(tempo2)>target)
        {
            tempo2 -= Time.deltaTime;
        }
        if (target==0)
        {
            //tempo=2f;
            if (movementCurve.Evaluate(tempo2)<-0.01f)
            {
                tempo2 += Time.deltaTime;
            }
            else if (movementCurve.Evaluate(tempo2)>0.01f)
            {
                tempo2 -= Time.deltaTime;
            }
        }
       // Debug.Log(movementCurve.Evaluate(tempo));
        anim.SetFloat(valorMudar,movementCurve.Evaluate(tempo2));
         
    }
    public void LimparAnimacaoAtual()
    {
        animacaoTocando="";
    }
    void Update()
    {
        
            Vector3 posOlhar = mycam.position+mycam.forward*4;
            posOlhar= new Vector3(posOlhar.x,transform.position.y,posOlhar.z);
            Quaternion lookRotation = Quaternion.LookRotation(posOlhar - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 4);
        
            


        posicaoFixa.position = transform.position;
        if (animacaoTocando==""&& Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth(1f,"valorY");
        }
        
        if (animacaoTocando==""&&  Input.GetKey(KeyCode.S)&& !Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth(-1f,"valorY");
            
        }
        if (animacaoTocando==""&& Input.GetKey(KeyCode.D)&& !Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth2(1f,"valorX");
        }
        if (animacaoTocando==""&& Input.GetKey(KeyCode.A)&& !Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth2(-1f,"valorX");
        }


        if (animacaoTocando==""&& Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth(2f,"valorY");
            
            
        }
        if (animacaoTocando==""&& Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth(-2f,"valorY");
        }
        if (animacaoTocando==""&& Input.GetKey(KeyCode.D)&& Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth2(2f,"valorX");
            
        }
        if (animacaoTocando==""&& Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.LeftShift))
        {
            MoveSmooth2(-2f,"valorX");
        }


        if (animacaoTocando==""&& !Input.GetKey(KeyCode.W) &&
        !Input.GetKey(KeyCode.S))
        {
            MoveSmooth(0f,"valorY");
        }
        if (animacaoTocando==""&& !Input.GetKey(KeyCode.D)&&
        !Input.GetKey(KeyCode.A))
        {
            MoveSmooth2(0f,"valorX");
        }

        if (animacaoTocando==""&& Input.GetKeyDown(KeyCode.C) && !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.LeftShift))
        {
            deitado=!deitado;
        }

        if (animacaoTocando==""&& deitado==true)
        {
            if (blendAtual!="3")
            {
                anim.CrossFade("deitado",0.3f);
                anim.CrossFade("deitado",0.3f,1);
                blendAtual="3";
            }
        }
        else if (animacaoTocando==""&& deitado==false && Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.LeftShift))
        {
            if (blendAtual!="2")
            {
                anim.CrossFade("agachado",0.3f);
                anim.CrossFade("agachado",0.3f,1);
                blendAtual="2";
            }
        }
       
        else if (animacaoTocando==""&& deitado==false && !Input.GetKey(KeyCode.LeftControl))
        {
            if (blendAtual!="1")
            {
                anim.CrossFade("andando",0.3f);
                anim.CrossFade("andando",0.3f,1);
                blendAtual="1";
            }
        }

        //====PEGAR OBJETO CHAO ====
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (animacaoTocando!="PegarChao")
            {
                 anim.CrossFade("PegarChao",0.3f);
                 animacaoTocando="PegarChao";
            }
          
        }
    }
}
