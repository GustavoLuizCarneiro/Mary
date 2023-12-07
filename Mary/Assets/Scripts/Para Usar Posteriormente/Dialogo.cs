using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
public GameObject Dialogo1;
public GameObject Dialogo2, Dialogo3, Dialogo4, tudo;
public int cont;

void Start(){
    cont = 1;
}

void Update(){
    if(Dialogo1 == true && Input.GetKeyDown(KeyCode.Space)){
        Dialogo2.SetActive(true);
        Dialogo1.SetActive(false);
        cont++;
    }
    Dragao();
    Contnuar();
    Gremio();
}
void Contnuar(){
    if(Dialogo2 == true && Input.GetKeyDown(KeyCode.Space)){
        Dialogo3.SetActive(true);
        Dialogo2.SetActive(false);
    }
}
void Gremio(){
    if(Dialogo3 == true && Input.GetKeyDown(KeyCode.Space)){
        Dialogo4.SetActive(true);
        Dialogo3.SetActive(false);
    }
}
void Dragao(){
    if(Dialogo4 == true && Input.GetKeyDown(KeyCode.Space)){
        Destroy(tudo);
    }
}
}