using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenaSelecaoMapa : MonoBehaviour
{
    // Método que carrega a cena de seleção de mapas
    public void CarregarCenaSelecaoMapas()
    {
        // Carrega a cena "MenuObjetivoDoJogo" utilizando o SceneManager
        SceneManager.LoadScene("MenuObjetivoDoJogo");
    }

    // Método que fecha o aplicativo
    public void Quit()
    {
        // Fecha o aplicativo utilizando o método Application.Quit()
        Application.Quit();
    }
}
