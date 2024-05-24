using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFimDeJogo : MonoBehaviour
{
    // M�todo chamado antes do primeiro frame de atualiza��o
    void Start()
    {
        // N�o h� c�digo aqui, pois n�o � necess�rio fazer nada no in�cio
    }

    // M�todo chamado a cada frame (atualiza��o do jogo)
    void Update()
    {
        // Define o cursor do mouse como vis�vel e desbloqueado
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // M�todo p�blico chamado quando o jogador seleciona a op��o de reiniciar o jogo
    public void ResetGame()
    {
        // Carrega a cena do menu inicial do jogo
        SceneManager.LoadScene("MenuInicial");
    }

    // M�todo p�blico chamado quando o jogador seleciona a op��o de sair do jogo
    public void QuitGame()
    {
        // Fecha o jogo inteiramente
        Application.Quit();
    }
}
