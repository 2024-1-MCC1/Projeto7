using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviaLixo : MonoBehaviour
{
    // Array de prefabs de lixo que podem ser enviados
    public GameObject[] LixoPrefabs = new GameObject[4];

    // Tempo de espera entre envios de lixo (inicializado com 1 segundo)
    public float SendTimer = 1f;

    // Frequ�ncia de envio de lixo (inicializado com 3 segundos)
    public float Frequency = 3f;

    // Alcance m�ximo em X e Z para a gera��o de lixo
    public float alcanceX = 5f;
    public float alcanceZ = 5f;

    // Vari�vel para armazenar o �ndice do prefab de lixo a ser enviado
    public int i;

    // M�todo chamado a cada frame (atualiza��o do jogo)
    private void Update()
    {
        // Decrementa o tempo de espera entre envios de lixo
        SendTimer -= Time.deltaTime;

        // Verifica se o tempo de espera expirou
        if (SendTimer <= 0)
        {
            // Chama o m�todo para gerar lixo
            GerarLixo();
            // Reinicia o tempo de espera com a frequ�ncia de envio
            SendTimer = Frequency;
        }
    }

    // M�todo para gerar lixo
    void GerarLixo()
    {
        // Obt�m a posi��o do jogador
        Vector3 posicaoJogador = transform.position;

        // Gera um valor aleat�rio para X e Z dentro do alcance m�ximo
        float xAleatorio = Random.Range(-alcanceX, alcanceX);
        float zAleatorio = Random.Range(-alcanceZ, alcanceZ);

        // Gera um �ndice aleat�rio para selecionar um prefab de lixo
        i = Random.Range(0, 3);

        // Calcula a posi��o de gera��o do lixo com base na posi��o do jogador e nos valores aleat�rios
        Vector3 posicaoGeracao = new Vector3(posicaoJogador.x + xAleatorio, posicaoJogador.y + 1, posicaoJogador.z + zAleatorio);

        // Instancia o prefab de lixo selecionado na posi��o de gera��o
        Instantiate(LixoPrefabs[i], posicaoGeracao, Quaternion.identity);
    }
}
