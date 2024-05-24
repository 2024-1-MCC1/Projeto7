using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenaSelecaoMapa : MonoBehaviour
{
    // M�todo que carrega a cena de sele��o de mapas
    public void CarregarCenaSelecaoMapas()
    {
        // Carrega a cena "MenuObjetivoDoJogo" utilizando o SceneManager
        SceneManager.LoadScene("MenuObjetivoDoJogo");
    }

    // M�todo que fecha o aplicativo
    public void Quit()
    {
        // Fecha o aplicativo utilizando o m�todo Application.Quit()
        Application.Quit();
    }
}
