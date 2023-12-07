using UnityEngine;
using TMPro;

public class Inventario : MonoBehaviour
{
    public int paginaAtual = 1; 
    public TextMeshProUGUI textoPagina;

    public void AvancarPagina()
    {
        if (paginaAtual < 6)
        {
            paginaAtual++;
            AtualizarTextoPagina();
        }
    }

    public void RetrocederPagina()
    {
        if (paginaAtual > 1)
        {
            paginaAtual--;
            AtualizarTextoPagina();
        }
    }

    private void AtualizarTextoPagina()
    {
        textoPagina.text = paginaAtual.ToString() + " / 6" ;
    }
}