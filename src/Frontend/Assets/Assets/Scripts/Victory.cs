using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // Quantidade de lixo necessário para vencer o jogo
    public int LixoNecessario = 100;

    // Referência para a classe ColetaLixo
    public ColetaLixo coletalixo;

    // Variável booleana que indica se o jogo foi vencido
    public bool fimDeJogoVitoria = false;

    void Update()
    {
        // Verifica se a quantidade de lixo coletado é maior ou igual a LixoNecessario
        if (coletalixo.lixoColetado >= LixoNecessario)
        {
            // Define fimDeJogoVitoria como verdadeiro e carrega a cena "MenuFimDeJogo"
            fimDeJogoVitoria = true;
            SceneManager.LoadScene("MenuFimDeJogo");
        }
    }
}
