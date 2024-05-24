using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuObjDoJogo : MonoBehaviour
{
    // Método público chamado quando o jogador seleciona a opção de escolher um mapa
    public void CarregarSelecaoMapas()
    {
        // Carrega a cena de seleção de mapas
        SceneManager.LoadScene("SelecaoMapa");
    }
}
