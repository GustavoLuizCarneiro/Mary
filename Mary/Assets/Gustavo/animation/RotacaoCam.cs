using UnityEngine;

public class RotacaoCam : MonoBehaviour
{
    public float sensibilidadeMouse = 2.0f; // Ajuste a sensibilidade conforme necessário
    public Transform posicaoFixaa;

    private void Update()
    {
        // Obtém os movimentos do mouse
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotaciona o objeto (no caso, a câmera) com base nos movimentos do mouse
        //transform.Rotate(Vector3.up, mouseX * sensibilidadeMouse);
        transform.Rotate(Vector3.left, mouseY * sensibilidadeMouse);

        // Limita a rotação vertical da câmera para evitar inversões
        float anguloAtualX = transform.eulerAngles.x;
        if (anguloAtualX > 180f)
            anguloAtualX -= 360f;

        anguloAtualX = Mathf.Clamp(anguloAtualX, -80f, 80f);

        transform.eulerAngles = new Vector3(anguloAtualX, transform.eulerAngles.y, 0);

        posicaoFixaa.Rotate(Vector3.up, mouseX * sensibilidadeMouse);
    }
}