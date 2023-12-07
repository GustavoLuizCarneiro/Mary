using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // velocidade de rotação do objeto
    public float rotationSpeed = 10f;

    void Update()
    {
        // verifica se o botão esquerdo do mouse está sendo pressionado
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");

            transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);

            float mouseY = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up, mouseY * rotationSpeed * Time.deltaTime);
        }
    }
}

