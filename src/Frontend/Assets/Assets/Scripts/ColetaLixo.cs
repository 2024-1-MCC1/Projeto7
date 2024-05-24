using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaLixo : MonoBehaviour
{
    // Variável que armazena a quantidade de lixo coletado
    public int lixoColetado = 0;

    // Referência ao texto que exibe a pontuação
    public Text pontuacaoTexto;

    // Prefab do lixo que será instanciado
    public GameObject lixoPrefab;

    // Referência ao cronômetro do jogo
    public Cronometro cronometro;


    // Método chamado quando o objeto entra em contato com outro objeto (neste caso, o lixo)
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato é do tipo "Trash" (lixo)
        if (other.gameObject.tag == "Trash")
        {
            // Adiciona 3 segundos ao tempo restante do cronômetro
            cronometro.remainingTime += 3f;

            // Incrementa a quantidade de lixo coletado em 5 pontos
            lixoColetado += 5;

            // Atualiza o texto da pontuação com o novo valor
            pontuacaoTexto.text = "PONTOS: " + lixoColetado;

            // Exibe uma mensagem de debug com o valor atual da pontuação
            Debug.Log(lixoColetado);

            // Destroi o objeto de lixo que foi coletado
            Destroy(other.gameObject);
        }
    }
}