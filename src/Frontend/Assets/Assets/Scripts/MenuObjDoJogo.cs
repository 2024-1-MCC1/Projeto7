using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuObjDoJogo : MonoBehaviour
{
    // M�todo p�blico chamado quando o jogador seleciona a op��o de escolher um mapa
    public void CarregarSelecaoMapas()
    {
        // Carrega a cena de sele��o de mapas
        SceneManager.LoadScene("SelecaoMapa");
    }
}
