using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Cronometro : MonoBehaviour
{
    // Referência ao texto que exibe o tempo restante
    [SerializeField] TextMeshProUGUI timerText;

    // Tempo restante em segundos (inicializado com 60 segundos)
    [SerializeField] public float remainingTime = 60f;

    // Método chamado quando o componente é inicializado
    void Start()
    {
        // Não há código aqui, pois não é necessário fazer nada no início
    }

    // Método chamado a cada frame (atualização do jogo)
    void Update()
    {
        // Verifica se o tempo restante é maior que 0
        if (remainingTime > 0)
        {
            // Decrementa o tempo restante em função do tempo de frame (Time.deltaTime)
            remainingTime -= Time.deltaTime;
        }
        // Verifica se o tempo restante é menor que 0 (ou seja, o tempo expirou)
        else if (remainingTime < 0)
        {
            // Fixa o tempo restante em 0 para evitar valores negativos
            remainingTime = 0;
            // Muda a cor do texto do cronômetro para vermelho para indicar que o tempo expirou
            timerText.color = Color.red;
            // Carrega a cena de derrota quando o tempo expira
            SceneManager.LoadScene("MenuDerrota");
        }

        // Calcula os minutos e segundos restantes
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        // Formata o tempo restante em uma string no formato "mm:ss"
        string v = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Atualiza o texto do cronômetro com o tempo restante formatado
        timerText.text = v;
    }
}