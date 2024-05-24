using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Variável estática usada para controlar se o jogo está pausado ou não
    public static bool jogoPausado = false;

    // Referência ao objeto que exibe o menu de pausa na tela
    public GameObject menuPausaUI;

    // Referência a um componente ColetaLixo
    private ColetaLixo coletalixo;

    // Método chamado antes do primeiro frame de atualização
    private void Start()
    {
        // Desativa o menu de pausa
        menuPausaUI.SetActive(false);
    }

    // Método chamado a cada frame (atualização do jogo)
    void Update()
    {
        // Se o jogador pressionar a tecla ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Se o jogo estiver pausado
            if (jogoPausado)
            {
                // Retoma o jogo
                RetomarJogo();
            }
            else
            {
                // Pausa o jogo
                PausarJogo();
            }
        }
    }

    // Método público chamado quando o jogador seleciona a opção de retomar o jogo no menu de pausa
    public void RetomarJogo()
    {
        // Desativa o menu de pausa
        menuPausaUI.SetActive(false);

        // Desbloqueia o cursor do mouse
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Define a escala de tempo do jogo como 1 (para que o jogo volte a ser executado normalmente)
        Time.timeScale = 1f;

        // Define a variável jogoPausado como falsa
        jogoPausado = false;
    }

    // Método público chamado quando o jogador pressiona a tecla ESC e o jogo não está pausado
    public void PausarJogo()
    {
        // Ativa o menu de pausa
        menuPausaUI.SetActive(true);

        // Bloqueia o cursorCursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Define a escala de tempo do jogo como 0 (para pausar o jogo)
        Time.timeScale = 0f;

        // Define a variável jogoPausado como verdadeira
        jogoPausado = true;
    }

    // Método público chamado quando o jogador seleciona a opção de voltar para o menu inicial no menu de pausa
    public void VoltarMenuInicial()
    {
        // Carrega a cena do menu inicial do jogo
        SceneManager.LoadScene("MenuInicial");
    }
}
