using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class botao : MonoBehaviour
{
    public Image imagem1;
    public Image imagem2;
    public Image imagem3;
    public Image imagem4;
    public Image imagem5;
    public Image imagem6;
    public Image imagem7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //=====================================
        if (Input.GetKey(KeyCode.W))
        {
            imagem1.color = Color.red;
        }
        else
        {
            imagem1.color = Color.gray;
        }
        //=====================================
        if (Input.GetKey(KeyCode.S))
        {
            imagem2.color = Color.red;
        }
        else
        {
            imagem2.color = Color.gray;
        }
        //=====================================
        if (Input.GetKey(KeyCode.D))
        {
            imagem3.color = Color.red;
        }
        else
        {
            imagem3.color = Color.gray;
        }
        //=====================================
        if (Input.GetKey(KeyCode.A))
        {
            imagem4.color = Color.red;
        }
        else
        {
            imagem4.color = Color.gray;
        }
        //=====================================
        if (Input.GetKey(KeyCode.LeftShift))
        {
            imagem5.color = Color.red;
        }
        else
        {
            imagem5.color = Color.gray;
        }
        //=====================================
        if (Input.GetKey(KeyCode.LeftControl))
        {
            imagem6.color = Color.red;
        }
        else
        {
            imagem6.color = Color.gray;
        }
        //=====================================
        if (Input.GetKey(KeyCode.C))
        {
            imagem7.color = Color.red;
        }
        else
        {
            imagem7.color = Color.gray;
        }
    }
}
