using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFimDeJogo : MonoBehaviour
{
    // Método chamado antes do primeiro frame de atualização
    void Start()
    {
        // Não há código aqui, pois não é necessário fazer nada no início
    }

    // Método chamado a cada frame (atualização do jogo)
    void Update()
    {
        // Define o cursor do mouse como visível e desbloqueado
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Método público chamado quando o jogador seleciona a opção de reiniciar o jogo
    public void ResetGame()
    {
        // Carrega a cena do menu inicial do jogo
        SceneManager.LoadScene("MenuInicial");
    }

    // Método público chamado quando o jogador seleciona a opção de sair do jogo
    public void QuitGame()
    {
        // Fecha o jogo inteiramente
        Application.Quit();
    }
}
