using UnityEngine;

public class CameraFantasma : MonoBehaviour
{
    // Referência para a câmera
    public Camera minhaCamera;

    // Camada que você deseja ativar ou desativar
    public LayerMask minhaCamada;
    bool luz;
    public GameObject luz_;

    void Start()
    {
        // Ativar a camada inicialmente (opcional, dependendo do seu caso)
        AtivarCamada(false);
    }

    void Update()
    {
        // Exemplo: Ativar ou desativar a camada quando a barra de espaço for pressionada
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Inverte o estado atual da camada
            AtivarCamada(!EstaCamadaAtivada());
            luz = !luz;
        }
        if(luz == true)
        {
            luz_.SetActive(true);
        }
        else
        {
            luz_.SetActive(false);
        }
    }

    // Função para ativar ou desativar a camada
    void AtivarCamada(bool ativar)
    {
        if (ativar)
        {
            minhaCamera.cullingMask |= minhaCamada;
        }
        else
        {
            minhaCamera.cullingMask &= ~minhaCamada;
        }

    }

    // Função para verificar se a camada está ativada
    bool EstaCamadaAtivada()
    {
        return (minhaCamera.cullingMask & minhaCamada) != 0;
    }
}
