using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Cronometro : MonoBehaviour
{
    // Refer�ncia ao texto que exibe o tempo restante
    [SerializeField] TextMeshProUGUI timerText;

    // Tempo restante em segundos (inicializado com 60 segundos)
    [SerializeField] public float remainingTime = 60f;

    // M�todo chamado quando o componente � inicializado
    void Start()
    {
        // N�o h� c�digo aqui, pois n�o � necess�rio fazer nada no in�cio
    }

    // M�todo chamado a cada frame (atualiza��o do jogo)
    void Update()
    {
        // Verifica se o tempo restante � maior que 0
        if (remainingTime > 0)
        {
            // Decrementa o tempo restante em fun��o do tempo de frame (Time.deltaTime)
            remainingTime -= Time.deltaTime;
        }
        // Verifica se o tempo restante � menor que 0 (ou seja, o tempo expirou)
        else if (remainingTime < 0)
        {
            // Fixa o tempo restante em 0 para evitar valores negativos
            remainingTime = 0;
            // Muda a cor do texto do cron�metro para vermelho para indicar que o tempo expirou
            timerText.color = Color.red;
            // Carrega a cena de derrota quando o tempo expira
            SceneManager.LoadScene("MenuDerrota");
        }

        // Calcula os minutos e segundos restantes
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        // Formata o tempo restante em uma string no formato "mm:ss"
        string v = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Atualiza o texto do cron�metro com o tempo restante formatado
        timerText.text = v;
    }
}