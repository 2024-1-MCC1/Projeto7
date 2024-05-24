using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviaLixo : MonoBehaviour
{
    // Array de prefabs de lixo que podem ser enviados
    public GameObject[] LixoPrefabs = new GameObject[4];

    // Tempo de espera entre envios de lixo (inicializado com 1 segundo)
    public float SendTimer = 1f;

    // Frequência de envio de lixo (inicializado com 3 segundos)
    public float Frequency = 3f;

    // Alcance máximo em X e Z para a geração de lixo
    public float alcanceX = 5f;
    public float alcanceZ = 5f;

    // Variável para armazenar o índice do prefab de lixo a ser enviado
    public int i;

    // Método chamado a cada frame (atualização do jogo)
    private void Update()
    {
        // Decrementa o tempo de espera entre envios de lixo
        SendTimer -= Time.deltaTime;

        // Verifica se o tempo de espera expirou
        if (SendTimer <= 0)
        {
            // Chama o método para gerar lixo
            GerarLixo();
            // Reinicia o tempo de espera com a frequência de envio
            SendTimer = Frequency;
        }
    }

    // Método para gerar lixo
    void GerarLixo()
    {
        // Obtém a posição do jogador
        Vector3 posicaoJogador = transform.position;

        // Gera um valor aleatório para X e Z dentro do alcance máximo
        float xAleatorio = Random.Range(-alcanceX, alcanceX);
        float zAleatorio = Random.Range(-alcanceZ, alcanceZ);

        // Gera um índice aleatório para selecionar um prefab de lixo
        i = Random.Range(0, 3);

        // Calcula a posição de geração do lixo com base na posição do jogador e nos valores aleatórios
        Vector3 posicaoGeracao = new Vector3(posicaoJogador.x + xAleatorio, posicaoJogador.y + 1, posicaoJogador.z + zAleatorio);

        // Instancia o prefab de lixo selecionado na posição de geração
        Instantiate(LixoPrefabs[i], posicaoGeracao, Quaternion.identity);
    }
}
