using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaLixo : MonoBehaviour
{
    // Vari�vel que armazena a quantidade de lixo coletado
    public int lixoColetado = 0;

    // Refer�ncia ao texto que exibe a pontua��o
    public Text pontuacaoTexto;

    // Prefab do lixo que ser� instanciado
    public GameObject lixoPrefab;

    // Refer�ncia ao cron�metro do jogo
    public Cronometro cronometro;


    // M�todo chamado quando o objeto entra em contato com outro objeto (neste caso, o lixo)
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato � do tipo "Trash" (lixo)
        if (other.gameObject.tag == "Trash")
        {
            // Adiciona 3 segundos ao tempo restante do cron�metro
            cronometro.remainingTime += 3f;

            // Incrementa a quantidade de lixo coletado em 5 pontos
            lixoColetado += 5;

            // Atualiza o texto da pontua��o com o novo valor
            pontuacaoTexto.text = "PONTOS: " + lixoColetado;

            // Exibe uma mensagem de debug com o valor atual da pontua��o
            Debug.Log(lixoColetado);

            // Destroi o objeto de lixo que foi coletado
            Destroy(other.gameObject);
        }
    }
}